
using System.Drawing;
using System.Net;

namespace Laby_05_solar_system
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem4 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem6 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem7 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem8 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem9 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem10 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem11 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem12 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem13 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem14 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem15 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem16 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.SolarSystem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SolarDays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SolarSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolarDays)).BeginInit();
            this.SuspendLayout();
            // 
            // SolarSystem
            // 
            this.SolarSystem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            chartArea1.Name = "ChartArea1";
            this.SolarSystem.ChartAreas.Add(chartArea1);
            legendItem1.Color = System.Drawing.Color.SkyBlue;
            legendItem1.Name = "57.909.170";
            legendItem2.Color = System.Drawing.Color.DarkSalmon;
            legendItem2.Name = "108.208.926";
            legendItem3.Color = System.Drawing.Color.Gainsboro;
            legendItem3.Name = "149.597.887";
            legendItem4.Color = System.Drawing.Color.GreenYellow;
            legendItem4.Name = "227.936.637";
            legendItem5.Color = System.Drawing.Color.Azure;
            legendItem5.Name = "778.412.027";
            legendItem6.Color = System.Drawing.Color.MediumVioletRed;
            legendItem6.Name = "1.426.725.413";
            legendItem7.Color = System.Drawing.Color.AliceBlue;
            legendItem7.Name = "2.870.972.220";
            legendItem8.Color = System.Drawing.Color.DarkSeaGreen;
            legendItem8.Name = "4.498.252.900";
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.CustomItems.Add(legendItem3);
            legend1.CustomItems.Add(legendItem4);
            legend1.CustomItems.Add(legendItem5);
            legend1.CustomItems.Add(legendItem6);
            legend1.CustomItems.Add(legendItem7);
            legend1.CustomItems.Add(legendItem8);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend";
            legend1.Title = "Legend";
            legend1.TitleBackColor = System.Drawing.Color.SkyBlue;
            this.SolarSystem.Legends.Add(legend1);
            this.SolarSystem.Location = new System.Drawing.Point(12, 9);
            this.SolarSystem.Name = "SolarSystem";
            series1.BorderColor = System.Drawing.Color.Gray;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend";
            series1.Name = "[km]";
            this.SolarSystem.Series.Add(series1);
            this.SolarSystem.Size = new System.Drawing.Size(830, 450);
            this.SolarSystem.TabIndex = 1;
            this.SolarSystem.Text = "chart1";
            title1.Name = "Solar";
            title1.Text = "Solar System - distance from the Sun";
            this.SolarSystem.Titles.Add(title1);
            this.Load += new System.EventHandler(this.Chart1_Click);
            // 
            // SolarDays
            // 
            chartArea2.Name = "ChartArea1";
            this.SolarDays.ChartAreas.Add(chartArea2);
            legendItem9.Color = System.Drawing.Color.SkyBlue;
            legendItem9.Name = "87,96";
            legendItem10.Color = System.Drawing.Color.DarkSalmon;
            legendItem10.Name = "224,70";
            legendItem11.Color = System.Drawing.Color.Gainsboro;
            legendItem11.Name = "365,25";
            legendItem12.Color = System.Drawing.Color.GreenYellow;
            legendItem12.Name = "686,96";
            legendItem13.Color = System.Drawing.Color.Azure;
            legendItem13.Name = "4.333,28";
            legendItem14.Color = System.Drawing.Color.MediumVioletRed;
            legendItem14.Name = "10,756.20";
            legendItem15.Color = System.Drawing.Color.AliceBlue;
            legendItem15.Name = "30.707,49";
            legendItem16.Color = System.Drawing.Color.DarkSeaGreen;
            legendItem16.Name = "60.223,35";
            legend2.CustomItems.Add(legendItem9);
            legend2.CustomItems.Add(legendItem10);
            legend2.CustomItems.Add(legendItem11);
            legend2.CustomItems.Add(legendItem12);
            legend2.CustomItems.Add(legendItem13);
            legend2.CustomItems.Add(legendItem14);
            legend2.CustomItems.Add(legendItem15);
            legend2.CustomItems.Add(legendItem16);
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.Title = "Legenda";
            legend2.TitleBackColor = System.Drawing.Color.SkyBlue;
            this.SolarDays.Legends.Add(legend2);
            this.SolarDays.Location = new System.Drawing.Point(12, 491);
            this.SolarDays.Name = "SolarDays";
            series2.BorderColor = System.Drawing.Color.Gray;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "[days]";
            this.SolarDays.Series.Add(series2);
            this.SolarDays.Size = new System.Drawing.Size(830, 450);
            this.SolarDays.TabIndex = 2;
            this.SolarDays.Text = "chart1";
            title2.Name = "Dni";
            title2.Text = "Solar System - the times to aroud the Sun";
            this.SolarDays.Titles.Add(title2);
            this.Load += new System.EventHandler(this.chart1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.SolarDays);
            this.Controls.Add(this.SolarSystem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SolarSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolarDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart SolarSystem;
        private System.Windows.Forms.DataVisualization.Charting.Chart SolarDays;
    }
}

