﻿using ETD.Models.Objects;
using ETD.Services;
using ETD.ViewsPresenters.MapSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Equipment Model Object
/// </summary>

namespace ETD.CustomObjects.CustomUIObjects
{
	class EquipmentPin : Pin
	{
		internal static int size = 30;

		private Equipment equipment;

		public EquipmentPin(Equipment equipment, MapSectionPage mapSection) : base(equipment, mapSection, size)
		{
			this.equipment = equipment; //Providing a link to the equipment that this pin represents
			
			base.setImage(TechnicalServices.getImage(equipment.getEquipmentType())); //Setting background image
						
			//Adding contect menu so that the user can delete the equipment
			MenuItem menuItem = new MenuItem();
			menuItem.Header = "Delete equipment";
			menuItem.Click += DeleteEquipment_Click;

			ContextMenu contextMenu = new ContextMenu();
			contextMenu.Items.Add(menuItem);

			this.ContextMenu = contextMenu;
		}

		//Deleting euqipment object (context menu item click)
		private void DeleteEquipment_Click(object sender, RoutedEventArgs e)
		{
			Equipment.DeleteEquipment(equipment);
		}

		//Handle special collisions between a Equipment and another pin
		internal override bool HandleSpecialCollisions(Pin fixedPin)
		{
			//SpecialCollision: Equipment is dropped on a team with sufficient overlap, add the equipment to the team
			if(fixedPin.IsOfType("TeamPin") && SufficientOverlap(fixedPin))
			{
				TeamPin teamPin = (TeamPin)fixedPin;
				teamPin.getTeam().AddEquipment(equipment);
                //MessageBox.Show(teamPin.getTeam().getName());
				equipment.setAssigned(true);
				return true;
			}

			//If there are no special conditions return false
			return false;
		}
	}
}