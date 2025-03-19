
namespace JP4
{
    partial class Form_janela_report01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_producao_pico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataSetmysqlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_mysql = new JP4.DataSet_mysql();
            this.chart_producao_extrusora = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_pico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetmysqlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_mysql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_extrusora)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_producao_pico
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_producao_pico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_producao_pico.Legends.Add(legend3);
            this.chart_producao_pico.Location = new System.Drawing.Point(12, 97);
            this.chart_producao_pico.Name = "chart_producao_pico";
            this.chart_producao_pico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Maquina";
            this.chart_producao_pico.Series.Add(series3);
            this.chart_producao_pico.Size = new System.Drawing.Size(1116, 243);
            this.chart_producao_pico.TabIndex = 4;
            this.chart_producao_pico.Text = "chart1";
            // 
            // dataSetmysqlBindingSource
            // 
            this.dataSetmysqlBindingSource.DataSource = this.dataSet_mysql;
            this.dataSetmysqlBindingSource.Position = 0;
            // 
            // dataSet_mysql
            // 
            this.dataSet_mysql.DataSetName = "DataSet_mysql";
            this.dataSet_mysql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart_producao_extrusora
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_producao_extrusora.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_producao_extrusora.Legends.Add(legend4);
            this.chart_producao_extrusora.Location = new System.Drawing.Point(12, 346);
            this.chart_producao_extrusora.Name = "chart_producao_extrusora";
            this.chart_producao_extrusora.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Maquina";
            this.chart_producao_extrusora.Series.Add(series4);
            this.chart_producao_extrusora.Size = new System.Drawing.Size(1116, 243);
            this.chart_producao_extrusora.TabIndex = 5;
            this.chart_producao_extrusora.Text = "chart1";
            // 
            // Form_janela_report01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 635);
            this.Controls.Add(this.chart_producao_extrusora);
            this.Controls.Add(this.chart_producao_pico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_janela_report01";
            this.Text = "Relatório";
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_pico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetmysqlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_mysql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_producao_extrusora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_producao_pico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_producao_extrusora;
        private System.Windows.Forms.BindingSource dataSetmysqlBindingSource;
        private DataSet_mysql dataSet_mysql;
    }
}