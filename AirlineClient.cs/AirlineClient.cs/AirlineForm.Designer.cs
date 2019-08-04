namespace AirlineClient.cs
{
    partial class AirlineForm
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
            this.Source = new System.Windows.Forms.Label();
            this.textSource = new System.Windows.Forms.TextBox();
            this.destination = new System.Windows.Forms.Label();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.btnGetRoutes = new System.Windows.Forms.Button();
            this.lblRoutes = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Source
            // 
            this.Source.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Source.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Source.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Source.Location = new System.Drawing.Point(24, 91);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(100, 20);
            this.Source.TabIndex = 0;
            this.Source.Text = "    Source";
            this.Source.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Source.Click += new System.EventHandler(this.Source_Click);
            // 
            // textSource
            // 
            this.textSource.Location = new System.Drawing.Point(130, 91);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(100, 20);
            this.textSource.TabIndex = 1;
            // 
            // destination
            // 
            this.destination.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.destination.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(24, 134);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(100, 20);
            this.destination.TabIndex = 2;
            this.destination.Text = "Destination";
            this.destination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(130, 134);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(100, 20);
            this.textDestination.TabIndex = 3;
            // 
            // btnGetRoutes
            // 
            this.btnGetRoutes.BackColor = System.Drawing.SystemColors.Info;
            this.btnGetRoutes.Location = new System.Drawing.Point(130, 177);
            this.btnGetRoutes.Name = "btnGetRoutes";
            this.btnGetRoutes.Size = new System.Drawing.Size(100, 20);
            this.btnGetRoutes.TabIndex = 4;
            this.btnGetRoutes.Text = "Get Routes";
            this.btnGetRoutes.UseVisualStyleBackColor = false;
            this.btnGetRoutes.Click += new System.EventHandler(this.btnGetRoutes_Click);
            // 
            // lblRoutes
            // 
            this.lblRoutes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblRoutes.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoutes.Location = new System.Drawing.Point(34, 234);
            this.lblRoutes.Name = "lblRoutes";
            this.lblRoutes.Size = new System.Drawing.Size(143, 29);
            this.lblRoutes.TabIndex = 5;
            this.lblRoutes.Text = "The possible routes are..";
            this.lblRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoute
            // 
            this.lblRoute.BackColor = System.Drawing.SystemColors.Info;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(34, 263);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(256, 46);
            this.lblRoute.TabIndex = 6;
            this.lblRoute.Text = "Enter Source, destination and click on Get Routes.";
            this.lblRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(307, 426);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblRoutes);
            this.Controls.Add(this.btnGetRoutes);
            this.Controls.Add(this.textDestination);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.textSource);
            this.Controls.Add(this.Source);
            this.Name = "AirlineForm";
            this.Text = "AIRLINE APP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.Button btnGetRoutes;

        public System.Windows.Forms.TextBox textSource;
        private System.Windows.Forms.Label lblRoutes;
        private System.Windows.Forms.Label lblRoute;
    }
}

