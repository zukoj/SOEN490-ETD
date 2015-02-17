﻿using ETD.ViewsPresenters.MapSection;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using ETD.Models.Objects;
using ETD.Services;


namespace ETD.Models.CustomUIObjects
{
    public class AdditionalInfoGrid : Grid
    {
        public int AddtionalInfoSize;
        public AdditionalInfo gr;

        public AdditionalInfoGrid(AdditionalInfo AI, AdditionalInfoPage AIPmap, int size)
            : base()
        {
            this.gr = AI;
            this.Name = AI.getAdditionalinfoName();
            this.Tag = "additionalinfo";
            this.AddtionalInfoSize=size;
            this.Width = size;
            this.Height = size;
            this.MouseLeftButtonDown += new MouseButtonEventHandler(AIPmap.DragStart);
            this.MouseLeftButtonUp += new MouseButtonEventHandler(AIPmap.DragStop);
            this.MouseMove += new MouseEventHandler(AIPmap.DragMove);
            this.ContextMenu = AIPmap.Resources["AIcontext"] as ContextMenu;
            (this.ContextMenu.Items[0] as MenuItem).IsChecked = true;
            
            Rectangle imageRectangle = new Rectangle();
            imageRectangle.Width = size;
            imageRectangle.Height = size;
            AdditionalInfos AIP = (AdditionalInfos)Enum.Parse(typeof(AdditionalInfos), this.Name);
            ImageBrush img = new ImageBrush();
            img.ImageSource = TechnicalServices.getImage(AIP);
            imageRectangle.Fill = img;
            this.Children.Add(imageRectangle);
        }
 

        public void ScalePin(String size)
        {
            if (size.Equals("small"))
            {

                MessageBox.Show("hi");
                Rectangle imageRectangle = new Rectangle();
                AdditionalInfos AIP = (AdditionalInfos)Enum.Parse(typeof(AdditionalInfos), this.Name);
                ImageBrush img = new ImageBrush();
                img.ImageSource = TechnicalServices.getImage(AIP);
                imageRectangle.Width = 90;
                imageRectangle.Fill = img;
                gr.setAISize(90);
                this.AddtionalInfoSize = 90;

            }

            if (size.Equals("medium"))
            {
                gr.setAISize(60);
                this.AddtionalInfoSize = 60;
            }

            if (size.Equals("large"))
            {
                gr.setAISize(100);
                this.AddtionalInfoSize = 100;
            }
        }

      
    }

    class AdditionalInfoGridLines : Grid
    {
        public AdditionalInfo gr;

        public AdditionalInfoGridLines(AdditionalInfo AI, AdditionalInfoPage AIPmap, double w, double h)
            : base()
        {
            this.gr = AI;
            this.Name = AI.getAdditionalinfoName();
            this.Tag = "line";
            this.Width = w;
            this.Height = h;

            ///////////////////////////////////////////////////////////////////////////////////////////////////

         //   this.MouseLeftButtonDown += new MouseButtonEventHandler(AIPmap.DrawingStart);
           // this.MouseRightButtonDown += new MouseButtonEventHandler(AIPmap.EraseLine);
          //  this.MouseLeftButtonUp += new MouseButtonEventHandler(AIPmap.DrawingStop);
         //   this.MouseMove += new MouseEventHandler(AIPmap.Move);
         //   this.MouseUp += new MouseButtonEventHandler(AIPmap.DrawingMove);
       
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            this.ContextMenu = AIPmap.Resources["AIcontext"] as ContextMenu;
            (this.ContextMenu.Items[0] as MenuItem).IsChecked = true;
            Rectangle imageRectangle = new Rectangle();
            imageRectangle.Width = w;
            imageRectangle.Height = h;
            AdditionalInfos AIP = (AdditionalInfos)Enum.Parse(typeof(AdditionalInfos), this.Name);
            ImageBrush img = new ImageBrush();
            img.ImageSource = TechnicalServices.getImage(AIP);
            imageRectangle.Fill = img;
            this.Children.Add(imageRectangle);
        }

    }
}