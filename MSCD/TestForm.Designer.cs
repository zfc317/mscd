namespace MSCD.UI
{
    partial class TestForm
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
            this.mapControl1 = new SuperMap.UI.MapControl();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Action = SuperMap.UI.Action.SelectLine;
            this.mapControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.InteractionMode = SuperMap.UI.InteractionMode.Default;
            this.mapControl1.IsCursorCustomized = false;
            this.mapControl1.IsWaitCursorEnabled = true;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.mapControl1.MarginPanEnabled = true;
            this.mapControl1.MarginPanPercent = 0.5D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.RefreshAtTracked = true;
            this.mapControl1.RefreshInInvalidArea = false;
            this.mapControl1.RollingWheelWithoutDelay = false;
            this.mapControl1.SelectionMode = SuperMap.UI.SelectionMode.ContainInnerPoint;
            this.mapControl1.SelectionPixelTolerance = 1;
            this.mapControl1.Size = new System.Drawing.Size(704, 413);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 413);
            this.Controls.Add(this.mapControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMap.UI.MapControl mapControl1;
    }
}