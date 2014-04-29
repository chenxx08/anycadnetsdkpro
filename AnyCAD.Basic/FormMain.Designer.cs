namespace AnyCAD.Basic
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDXFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadeWithEdgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeWithPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.largePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.projectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projLineToSurfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.faceTriangulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickFaceEdgePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.chamferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.primitiveToolStripMenuItem,
            this.featureToolStripMenuItem,
            this.geometryToolStripMenuItem,
            this.pickToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.importDXFToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTLToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // sTLToolStripMenuItem
            // 
            this.sTLToolStripMenuItem.Name = "sTLToolStripMenuItem";
            this.sTLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sTLToolStripMenuItem.Text = "STEP/IGES/STL";
            this.sTLToolStripMenuItem.Click += new System.EventHandler(this.sTLToolStripMenuItem_Click);
            // 
            // importDXFToolStripMenuItem
            // 
            this.importDXFToolStripMenuItem.Name = "importDXFToolStripMenuItem";
            this.importDXFToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.importDXFToolStripMenuItem.Text = "Load DXF";
            this.importDXFToolStripMenuItem.Click += new System.EventHandler(this.importDXFToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shadeToolStripMenuItem,
            this.shadeWithEdgeToolStripMenuItem,
            this.edgeWithPointsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.zoomAllToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showGridToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // shadeToolStripMenuItem
            // 
            this.shadeToolStripMenuItem.Name = "shadeToolStripMenuItem";
            this.shadeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.shadeToolStripMenuItem.Text = "Shade";
            this.shadeToolStripMenuItem.Click += new System.EventHandler(this.shadeToolStripMenuItem_Click);
            // 
            // shadeWithEdgeToolStripMenuItem
            // 
            this.shadeWithEdgeToolStripMenuItem.Name = "shadeWithEdgeToolStripMenuItem";
            this.shadeWithEdgeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.shadeWithEdgeToolStripMenuItem.Text = "Shade with edge";
            this.shadeWithEdgeToolStripMenuItem.Click += new System.EventHandler(this.shadeWithEdgeToolStripMenuItem_Click);
            // 
            // edgeWithPointsToolStripMenuItem
            // 
            this.edgeWithPointsToolStripMenuItem.Name = "edgeWithPointsToolStripMenuItem";
            this.edgeWithPointsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.edgeWithPointsToolStripMenuItem.Text = "Edge with points";
            this.edgeWithPointsToolStripMenuItem.Click += new System.EventHandler(this.edgeWithPointsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // zoomAllToolStripMenuItem
            // 
            this.zoomAllToolStripMenuItem.Name = "zoomAllToolStripMenuItem";
            this.zoomAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.zoomAllToolStripMenuItem.Text = "Zoom All";
            this.zoomAllToolStripMenuItem.Click += new System.EventHandler(this.zoomAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(159, 6);
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // primitiveToolStripMenuItem
            // 
            this.primitiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sphereToolStripMenuItem,
            this.boxToolStripMenuItem,
            this.cylinderToolStripMenuItem,
            this.coneToolStripMenuItem,
            this.customToolStripMenuItem,
            this.toolStripMenuItem1,
            this.textToolStripMenuItem,
            this.toolStripMenuItem6,
            this.largePointsToolStripMenuItem});
            this.primitiveToolStripMenuItem.Name = "primitiveToolStripMenuItem";
            this.primitiveToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.primitiveToolStripMenuItem.Text = "Primitive";
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.sphereToolStripMenuItem_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // cylinderToolStripMenuItem
            // 
            this.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem";
            this.cylinderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cylinderToolStripMenuItem.Text = "Cylinder";
            this.cylinderToolStripMenuItem.Click += new System.EventHandler(this.cylinderToolStripMenuItem_Click);
            // 
            // coneToolStripMenuItem
            // 
            this.coneToolStripMenuItem.Name = "coneToolStripMenuItem";
            this.coneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coneToolStripMenuItem.Text = "Cone";
            this.coneToolStripMenuItem.Click += new System.EventHandler(this.coneToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(149, 6);
            // 
            // largePointsToolStripMenuItem
            // 
            this.largePointsToolStripMenuItem.Name = "largePointsToolStripMenuItem";
            this.largePointsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.largePointsToolStripMenuItem.Text = "Large Points";
            this.largePointsToolStripMenuItem.Click += new System.EventHandler(this.largePointsToolStripMenuItem_Click);
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrudeToolStripMenuItem,
            this.revoleToolStripMenuItem,
            this.splitToolStripMenuItem,
            this.toolStripMenuItem2,
            this.projectionToolStripMenuItem,
            this.projLineToSurfaceToolStripMenuItem,
            this.toolStripMenuItem7,
            this.chamferToolStripMenuItem,
            this.filletToolStripMenuItem});
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // extrudeToolStripMenuItem
            // 
            this.extrudeToolStripMenuItem.Name = "extrudeToolStripMenuItem";
            this.extrudeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.extrudeToolStripMenuItem.Text = "Extrude";
            this.extrudeToolStripMenuItem.Click += new System.EventHandler(this.extrudeToolStripMenuItem_Click);
            // 
            // revoleToolStripMenuItem
            // 
            this.revoleToolStripMenuItem.Name = "revoleToolStripMenuItem";
            this.revoleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.revoleToolStripMenuItem.Text = "Revole";
            this.revoleToolStripMenuItem.Click += new System.EventHandler(this.revoleToolStripMenuItem_Click);
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.splitToolStripMenuItem.Text = "Split";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // projectionToolStripMenuItem
            // 
            this.projectionToolStripMenuItem.Name = "projectionToolStripMenuItem";
            this.projectionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.projectionToolStripMenuItem.Text = "Projection";
            this.projectionToolStripMenuItem.Click += new System.EventHandler(this.projectionToolStripMenuItem_Click);
            // 
            // projLineToSurfaceToolStripMenuItem
            // 
            this.projLineToSurfaceToolStripMenuItem.Name = "projLineToSurfaceToolStripMenuItem";
            this.projLineToSurfaceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.projLineToSurfaceToolStripMenuItem.Text = "Proj Line to Surface";
            this.projLineToSurfaceToolStripMenuItem.Click += new System.EventHandler(this.projLineToSurfaceToolStripMenuItem_Click);
            // 
            // geometryToolStripMenuItem
            // 
            this.geometryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curveToolStripMenuItem,
            this.surfaceToolStripMenuItem,
            this.toolStripMenuItem4,
            this.faceTriangulateToolStripMenuItem});
            this.geometryToolStripMenuItem.Name = "geometryToolStripMenuItem";
            this.geometryToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.geometryToolStripMenuItem.Text = "Geometry";
            // 
            // curveToolStripMenuItem
            // 
            this.curveToolStripMenuItem.Name = "curveToolStripMenuItem";
            this.curveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.curveToolStripMenuItem.Text = "Curve";
            this.curveToolStripMenuItem.Click += new System.EventHandler(this.curveToolStripMenuItem_Click);
            // 
            // surfaceToolStripMenuItem
            // 
            this.surfaceToolStripMenuItem.Name = "surfaceToolStripMenuItem";
            this.surfaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.surfaceToolStripMenuItem.Text = "Surface";
            this.surfaceToolStripMenuItem.Click += new System.EventHandler(this.surfaceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(158, 6);
            // 
            // faceTriangulateToolStripMenuItem
            // 
            this.faceTriangulateToolStripMenuItem.Name = "faceTriangulateToolStripMenuItem";
            this.faceTriangulateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.faceTriangulateToolStripMenuItem.Text = "Face Triangulate";
            this.faceTriangulateToolStripMenuItem.Click += new System.EventHandler(this.faceTriangulateToolStripMenuItem_Click);
            // 
            // pickToolStripMenuItem
            // 
            this.pickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickPointToolStripMenuItem,
            this.pickNodeToolStripMenuItem,
            this.pickGroupToolStripMenuItem,
            this.pickFaceEdgePointToolStripMenuItem});
            this.pickToolStripMenuItem.Name = "pickToolStripMenuItem";
            this.pickToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.pickToolStripMenuItem.Text = "Pick";
            // 
            // pickPointToolStripMenuItem
            // 
            this.pickPointToolStripMenuItem.Name = "pickPointToolStripMenuItem";
            this.pickPointToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pickPointToolStripMenuItem.Text = "Pick point";
            this.pickPointToolStripMenuItem.Click += new System.EventHandler(this.pickPointToolStripMenuItem_Click);
            // 
            // pickNodeToolStripMenuItem
            // 
            this.pickNodeToolStripMenuItem.Name = "pickNodeToolStripMenuItem";
            this.pickNodeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pickNodeToolStripMenuItem.Text = "Pick Node";
            this.pickNodeToolStripMenuItem.Click += new System.EventHandler(this.pickNodeToolStripMenuItem_Click);
            // 
            // pickGroupToolStripMenuItem
            // 
            this.pickGroupToolStripMenuItem.Name = "pickGroupToolStripMenuItem";
            this.pickGroupToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pickGroupToolStripMenuItem.Text = "Pick Group";
            this.pickGroupToolStripMenuItem.Click += new System.EventHandler(this.pickGroupToolStripMenuItem_Click);
            // 
            // pickFaceEdgePointToolStripMenuItem
            // 
            this.pickFaceEdgePointToolStripMenuItem.Name = "pickFaceEdgePointToolStripMenuItem";
            this.pickFaceEdgePointToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pickFaceEdgePointToolStripMenuItem.Text = "Pick Face/Edge/Point";
            this.pickFaceEdgePointToolStripMenuItem.Click += new System.EventHandler(this.pickFaceEdgePointToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(173, 6);
            // 
            // chamferToolStripMenuItem
            // 
            this.chamferToolStripMenuItem.Name = "chamferToolStripMenuItem";
            this.chamferToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.chamferToolStripMenuItem.Text = "Chamfer";
            this.chamferToolStripMenuItem.Click += new System.EventHandler(this.chamferToolStripMenuItem_Click);
            // 
            // filletToolStripMenuItem
            // 
            this.filletToolStripMenuItem.Name = "filletToolStripMenuItem";
            this.filletToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.filletToolStripMenuItem.Text = "Fillet";
            this.filletToolStripMenuItem.Click += new System.EventHandler(this.filletToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 453);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "AnyCAD .Net SDK Demo - 3D Graphics Component for C#";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadeWithEdgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeWithPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem projectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDXFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zoomAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem faceTriangulateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickFaceEdgePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projLineToSurfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem largePointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem chamferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filletToolStripMenuItem;

    }
}

