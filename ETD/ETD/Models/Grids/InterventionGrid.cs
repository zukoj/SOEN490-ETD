﻿using ETD.ViewsPresenters.MapSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media.Effects;
using ETD.Models.Services;

namespace ETD.Models.Grids
{
	public class InterventionGrid : Grid
	{
        public InterventionGrid(int interventionNumber, MapSectionPage mapSection, int size) : base()
        {
			this.Name = "Intervention_" + interventionNumber;
			this.Tag = "intervention";
			this.Width = size;
			this.Height = size;
			this.MouseLeftButtonDown += new MouseButtonEventHandler(mapSection.DragStart);
			this.MouseLeftButtonUp += new MouseButtonEventHandler(mapSection.DragStop);
			this.MouseMove += new MouseEventHandler(mapSection.DragMove);

			Rectangle imageRectangle = new Rectangle();
			imageRectangle.Width = size;
			imageRectangle.Height = size;
			ImageBrush img = new ImageBrush();
			img.ImageSource = TechnicalServices.getImage("intervention");
			imageRectangle.Fill = img;
			this.Children.Add(imageRectangle);

			Viewbox viewbox = new Viewbox();
			viewbox.Width = size;
			viewbox.Height = size;
			viewbox.HorizontalAlignment = HorizontalAlignment.Center;
			viewbox.VerticalAlignment = VerticalAlignment.Center;
			this.Children.Add(viewbox);

			TextBlock nameLabel = new TextBlock();
			nameLabel.Text = interventionNumber.ToString();
			nameLabel.FontWeight = FontWeights.DemiBold;
			nameLabel.IsHitTestVisible = false;

			viewbox.Child = nameLabel;
        }
	}
}
