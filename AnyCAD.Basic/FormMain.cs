using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AnyCAD.Platform;

namespace AnyCAD.Basic
{
    public partial class FormMain : Form
    {
        // Render Control
        private Presentation.RenderWindow3d renderView;
        private int shapeId = 100;
        public FormMain()
        {
            InitializeComponent();
            MessageBox.Show("AnyCAD .Net SDK PRO");
            // 
            // Create renderView
            // 
            this.renderView = new AnyCAD.Presentation.RenderWindow3d();
            this.renderView.Location = new System.Drawing.Point(0, 27);
            this.renderView.Size = this.Size;
            this.renderView.TabIndex = 1;
            this.Controls.Add(this.renderView);

            this.renderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnRenderWindow_MouseClick);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.renderView != null)
            {
                renderView.SetBackgroundColor(new ColorValue(168, 194, 239),
                    new ColorValue(190, 206, 240),
                    new ColorValue(210, 226, 240));
                this.renderView.View3d.ShowCoordinateAxis(true);

            }
        }
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if(renderView != null)
                renderView.Size = this.Size;
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape sphere = GlobalInstance.BrepTools.MakeSphere(new Vector3(0, 0, 0), 40);
            renderView.ShowGeometry(sphere, ++shapeId);
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape box = GlobalInstance.BrepTools.MakeBox(new Vector3(40, -20, 0), new Vector3(0, 0, 1), new Vector3(30, 40, 60));

            SceneNode sceneNode = renderView.ShowGeometry(box, ++shapeId);

            FaceStyle style = new FaceStyle();
            style.SetColor(new ColorValue(0.5f, 0.3f, 0, 0.5f));
            style.SetTransparent(true);
            sceneNode.SetFaceStyle(style);
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape cylinder = GlobalInstance.BrepTools.MakeCylinder(new Vector3(80, 0, 0), new Vector3(0, 0, 1), 20, 100, 315);
            SceneNode sceneNode = renderView.ShowGeometry(cylinder, ++shapeId);
            FaceStyle style = new FaceStyle();
            style.SetColor(new ColorValue(0.1f, 0.3f, 0.8f, 1));
            sceneNode.SetFaceStyle(style);
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape cylinder = GlobalInstance.BrepTools.MakeCone(new Vector3(120, 0, 0), new Vector3(0, 0, 1), 20, 100, 40, 315);
            renderView.ShowGeometry(cylinder, ++shapeId);
        }

        private void extrudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 20;
            // Create the outline edge
            TopoShape arc = GlobalInstance.BrepTools.MakeArc3Pts(new Vector3(-size, 0, 0), new Vector3(size, 0, 0), new Vector3(0, size, 0));
            TopoShape line1 = GlobalInstance.BrepTools.MakeLine(new Vector3(-size, -size, 0), new Vector3(-size, 0, 0));
            TopoShape line2 = GlobalInstance.BrepTools.MakeLine(new Vector3(size, -size, 0), new Vector3(size, 0, 0));
            TopoShape line3 = GlobalInstance.BrepTools.MakeLine(new Vector3(-size, -size, 0), new Vector3(size, -size, 0));

            TopoShapeGroup shapeGroup = new TopoShapeGroup();
            shapeGroup.Add(line1);
            shapeGroup.Add(arc);
            shapeGroup.Add(line2);
            shapeGroup.Add(line3);

            TopoShape wire = GlobalInstance.BrepTools.MakeWire(shapeGroup);
            TopoShape face = GlobalInstance.BrepTools.MakeFace(wire);

            // Extrude
            TopoShape extrude = GlobalInstance.BrepTools.Extrude(face, 100, new Vector3(0, 0, 1));
            renderView.ShowGeometry(extrude, ++shapeId);

            // Check find....
            SceneNode findNode = renderView.SceneManager.FindNode(shapeId);
            renderView.SceneManager.SelectNode(findNode);
        }

        private void revoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size = 10;
            // Create the outline edge
            TopoShape arc = GlobalInstance.BrepTools.MakeArc3Pts(new Vector3(-size, 0, 0), new Vector3(size, 0, 0), new Vector3(0, size, 0));
            TopoShape line1 = GlobalInstance.BrepTools.MakeLine(new Vector3(-size, -size, 0), new Vector3(-size, 0, 0));
            TopoShape line2 = GlobalInstance.BrepTools.MakeLine(new Vector3(size, -size, 0), new Vector3(size, 0, 0));
            TopoShape line3 = GlobalInstance.BrepTools.MakeLine(new Vector3(-size, -size, 0), new Vector3(size, -size, 0));

            TopoShapeGroup shapeGroup = new TopoShapeGroup();
            shapeGroup.Add(line1);
            shapeGroup.Add(arc);
            shapeGroup.Add(line2);
            shapeGroup.Add(line3);

            TopoShape wire = GlobalInstance.BrepTools.MakeWire(shapeGroup);

            TopoShape revole = GlobalInstance.BrepTools.Revol(wire, new Vector3(size * 3, 0, 0), new Vector3(0, 1, 0), 145);

            renderView.ShowGeometry(revole, ++shapeId);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.ClearScene();
        }

        private void sTLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "STL (*.stl)|*.stl|IGES (*.igs;*.iges)|*.igs;*.iges|STEP (*.stp;*.step)|*.stp;*.step|All Files(*.*)|*.*";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                TopoShape shape = GlobalInstance.BrepTools.LoadFile(dlg.FileName);
                renderView.RenderTimer.Enabled = false;
                if (shape != null)
                {

                    PhongMaterial material = new PhongMaterial();
                    material.SetAmbient(new ColorValue(0.24725f, 0.2245f, 0.0645f));
                    material.SetDiffuse(new ColorValue(0.84615f, 0.8143f, 0.2903f));
                    material.SetSpecular(new ColorValue(0.797357f, 0.723991f, 0.208006f));
                    material.SetShininess(83.2f);
                    FaceStyle faceStyle = new FaceStyle();
                    faceStyle.SetMaterial(material);
                    SceneManager sceneMgr = renderView.SceneManager;
                    TopoShapeGroup subGroup = GlobalInstance.TopoExplor.ExplorSubShapes(shape);
                    int nSize = subGroup.Size();
                    for (int ii = 0; ii < nSize; ++ii)
                    {
                        SceneNode node = GlobalInstance.TopoShapeConvert.ToEntityNode(subGroup.GetTopoShape(ii), 10f);
                        node.SetId(++shapeId);
                        node.SetFaceStyle(faceStyle);

                        sceneMgr.AddNode(node);
                    }
                }
                renderView.RenderTimer.Enabled = true;
            }

            renderView.View3d.FitAll();
            renderView.RequestDraw(EnumRenderHint.RH_LoadScene);
        }

        private void shadeWithEdgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.SetDisplayMode((int)(EnumDisplayStyle.DS_Face | EnumDisplayStyle.DS_Edge | EnumDisplayStyle.DS_Realistic));
            renderView.RequestDraw();
        }

        private void shadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.SetDisplayMode((int)(EnumDisplayStyle.DS_Face|EnumDisplayStyle.DS_Realistic));
            renderView.RequestDraw();
        }

        private void edgeWithPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.SetDisplayMode((int)(EnumDisplayStyle.DS_Edge|EnumDisplayStyle.DS_Vertex));
            renderView.RequestDraw();
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape cylinder = GlobalInstance.BrepTools.MakeCylinder(new Vector3(80, 0, 0), new Vector3(0, 0, 1), 20, 100, 315);

            TopoShape planeFace = GlobalInstance.BrepTools.MakePlaneFace(new Vector3(80, 0, 50), new Vector3(0, 0, 1), -100, 100, -100, 100);

            TopoShape rest = GlobalInstance.BrepTools.MakeSplit(cylinder, planeFace);
            renderView.ShowGeometry(rest, ++shapeId);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[] vb ={0,0,0,100,0,0,100,100,0};
            uint[] ib = { 0, 1, 2 };
            float[] cb = { 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1 };
            float[] nb = {};
            RenderableEntity entity = GlobalInstance.TopoShapeConvert.CreateColoredFaceEntity(vb, ib, nb, cb, new AABox(Vector3.ZERO, new Vector3(100, 100, 1)));

            EntitySceneNode node = new EntitySceneNode();
            node.SetEntity(entity);

            renderView.SceneManager.AddNode(node);
            renderView.RequestDraw();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                TextNode text = new TextNode();
                text.SetPosition(new Vector3(200, 200, 200));
                text.SetText("AnyCAD .Net SDK Pro");
                text.SetTextColor(new ColorValue(1, 0, 0, 1));

                renderView.SceneManager.AddNode(text);
            }
            {
                TextNode text = new TextNode();
                text.SetPosition(new Vector3(10, 50, 0));
                text.SetText("AnyCAD .Net SDK Pro 2D");
                text.SetTextColor(new ColorValue(0, 1, 0, 1));
                renderView.SceneManager.AddNode2d(text);
            }

            renderView.RequestDraw();
        }

        private bool m_PickPoint = false;
        private void pickPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_PickPoint = !m_PickPoint;
        }

        private void OnRenderWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (!m_PickPoint)
                return;

            Platform.Vector3 pt = renderView.HitPointOnShape(e.X, e.Y);
            if(pt != null)
            {
                // add a ball
                Platform.TopoShape shape = GlobalInstance.BrepTools.MakeSphere(pt, 2);
                renderView.ShowGeometry(shape, 100);
            }
            // Try the grid
            pt = renderView.HitPointOnGrid(e.X, e.Y);
            if (pt != null)
            {
                Platform.TopoShape shape = GlobalInstance.BrepTools.MakeSphere(pt, 2);
                renderView.ShowGeometry(shape, 100);
            }
        }

        private void projectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // construct a wire;
            Platform.Vector3List points = new Platform.Vector3List();
            points.Add(new Platform.Vector3(0, 0, 0));
            points.Add(new Platform.Vector3(0, 100, 0));
            points.Add(new Platform.Vector3(100, 100, 0));
            Platform.TopoShape wire = GlobalInstance.BrepTools.MakePolygon(points);
            renderView.ShowGeometry(wire, 200);

            Platform.Vector3 dirPlane1 = new Platform.Vector3(0, 1, 1);
            dirPlane1.Normalize();
            Platform.TopoShape newWire1 = GlobalInstance.BrepTools.ProjectOnPlane(wire, new Platform.Vector3(0, 0, 100),
                dirPlane1, new Platform.Vector3(0, 0, 1));

            Platform.Vector3 dirPlane2 = new Platform.Vector3(0, 1, -1);
            dirPlane2.Normalize();
            Platform.TopoShape newWire2 = GlobalInstance.BrepTools.ProjectOnPlane(wire, new Platform.Vector3(0, 0, 500),
                dirPlane2, new Platform.Vector3(0, 0, 1));

            Platform.TopoShapeGroup tsg = new Platform.TopoShapeGroup();
            tsg.Add(newWire1);
            tsg.Add(newWire2);
            Platform.TopoShape loft = GlobalInstance.BrepTools.MakeLoft(tsg, false);
            renderView.ShowGeometry(loft, 202);

            renderView.RequestDraw();
        }

        private void importDXFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "DXF (*.dxf)|*.dxf";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                AnyCAD.Exchange.DxfReader reader = new AnyCAD.Exchange.DxfReader();
                if (reader.Read(dlg.FileName, new ReadShapeContext(renderView.SceneManager)))
                    renderView.RequestDraw();
            }

            renderView.View3d.FitAll();
        }

        private void zoomAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.FitAll();
        }

        private void curveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.SetStandardView(3);

            Platform.LineStyle lineStyle = new Platform.LineStyle();
            lineStyle.SetLineWidth(0.5f);
            lineStyle.SetColor(ColorValue.BLUE);
            Platform.LineStyle lineStyle2 = new Platform.LineStyle();
            lineStyle2.SetLineWidth(0.5f);
            lineStyle2.SetColor(ColorValue.GREEN);

            Platform.TopoShape arc = GlobalInstance.BrepTools.MakeEllipseArc(Vector3.ZERO, 100, 50, 45, 270, Vector3.UNIT_Z);
            renderView.ShowGeometry(arc, 100);
 
            {
                Platform.GeomeCurve curve = new Platform.GeomeCurve();
                curve.Initialize(arc);

                float paramStart = curve.FirstParameter();
                float paramEnd = curve.LastParameter();

                float step = (paramEnd - paramStart) * 0.1f;

                for (float uu = paramStart; uu <= paramEnd; uu += step)
                {
                    Vector3 dir = curve.DN(uu, 1);
                    Vector3 pos = curve.Value(uu);

                    // 切线
                    {
                        Platform.TopoShape line = GlobalInstance.BrepTools.MakeLine(pos, pos + dir);
                        Platform.SceneNode node = renderView.ShowGeometry(line, 101);
                        node.SetLineStyle(lineStyle);
                    }
                    // 法线
                    {
                        Vector3 dirN = dir.CrossProduct(Vector3.UNIT_Z);
                        Platform.TopoShape line = GlobalInstance.BrepTools.MakeLine(pos, pos + dirN);
                        Platform.SceneNode node = renderView.ShowGeometry(line, 101);
                        node.SetLineStyle(lineStyle2);
                    }

                }

            }

            TopoShapeProperty property = new TopoShapeProperty();
            property.SetShape(arc);

            float len = property.EdgeLength();

            TextNode text = new TextNode();
            text.SetText(String.Format("Arc Length: {0}", len));
            text.SetPosition(new Vector3(100, 100, 0));

            renderView.SceneManager.ClearNodes2d();
            renderView.SceneManager.AddNode2d(text);

            renderView.RequestDraw();
        }

        private void surfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Platform.LineStyle lineStyle = new Platform.LineStyle();
            lineStyle.SetLineWidth(0.5f);
            lineStyle.SetColor(ColorValue.RED);

            Vector3List points = new Vector3List();
            points.Add(new Vector3(0, 0, 0));
            points.Add(new Vector3(50, 0, 0));
            points.Add(new Vector3(100, 0, 0));

            points.Add(new Vector3(0, 50, 0));
            points.Add(new Vector3(50, 50, 5));
            points.Add(new Vector3(100, 50, -5));

            points.Add(new Vector3(0, 150, 5));
            points.Add(new Vector3(50, 150, -5));
            points.Add(new Vector3(100, 150, 0));

            TopoShape face = GlobalInstance.BrepTools.MakeSurfaceFromPoints(points, 3, 3);

            renderView.ShowGeometry(face, 101);

            GeomeSurface surface = new GeomeSurface();
            surface.Initialize(face);
            float ufirst = surface.FirstUParameter();
            float uLarst = surface.LastUParameter();
            float vfirst = surface.FirstVParameter();
            float vLast = surface.LastVParameter();

            float ustep = (uLarst - ufirst) * 0.1f;
            float vstep = (vLast - vfirst) * 0.1f;
            for(float ii=ufirst; ii<=uLarst; ii+= ustep)
                for (float jj = vfirst; jj <= vLast; jj += vstep)
                {
                    Vector3List data = surface.D1(ii, jj);

                    Vector3 pos = data.Get(0);
                    Vector3 dirU = data.Get(1);
                    Vector3 dirV = data.Get(2);
                    Vector3 dir = dirV.CrossProduct(dirU);
                    dir.Normalize();
                    {
                        Platform.TopoShape line = GlobalInstance.BrepTools.MakeLine(pos, pos + dir*10.0f);
                        Platform.SceneNode node = renderView.ShowGeometry(line, 101);

                        node.SetLineStyle(lineStyle);
                    }
                }

            TopoShapeProperty property = new TopoShapeProperty();
            property.SetShape(face);

            float area = property.SurfaceArea();

            TextNode text = new TextNode();
            text.SetText(String.Format("Surface Area: {0}", area));
            text.SetPosition(new Vector3(100, 100, 0));
            renderView.SceneManager.ClearNodes2d();
            renderView.SceneManager.AddNode2d(text);

            renderView.RequestDraw();
        }

        private void faceTriangulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape circle = GlobalInstance.BrepTools.MakeCircle(Vector3.ZERO, 100, Vector3.UNIT_Z);
            TopoShape face = GlobalInstance.BrepTools.MakeFace(circle);
            if (face.GetShapeType() == (int)EnShapeType.Topo_FACE)
            {
                MessageBox.Show("This is a face!");
            }

            FaceTriangulation ft = new FaceTriangulation();
            ft.SetTolerance(5);
            ft.Perform(face);
            float[] points = ft.GetVertexBuffer();
            int pointCount = points.Length / 3;
            uint[] indexBuffer = ft.GetIndexBuffer();
            int faceCount = indexBuffer.Length / 3;
            float[] normals = ft.GetNormalBuffer();

            MessageBox.Show(String.Format("Point Count: {0}\n Face Count: {1}", pointCount, faceCount));

            float[] colorBuffer = new float[pointCount * 4];
            
            Random num = new Random();
            for (int ii = 0; ii < pointCount; ++ii)
            {
                int idx = ii * 4;
                colorBuffer[idx] = num.Next(0, 256)/256.0f;
                colorBuffer[idx+1] = num.Next(0, 256) / 256.0f;
                colorBuffer[idx+2] = num.Next(0, 256) / 256.0f;
                colorBuffer[idx+3] = 1;
            }

            RenderableEntity entity = GlobalInstance.TopoShapeConvert.CreateColoredFaceEntity(points, indexBuffer, normals, colorBuffer, face.GetBBox());

            EntitySceneNode node = new EntitySceneNode();
            node.SetEntity(entity);

            renderView.SceneManager.AddNode(node);
            renderView.RequestDraw();
            //////////////////////////////////////////////////////////////////////////
            // Code to get the mesh
            /*
            for (int ii = 0; ii < faceCount; ++ii)
            {
                int p0 = (int)indexBuffer[ii * 3];
                int p1 = (int)indexBuffer[ii * 3 + 1];
                int p2 = (int)indexBuffer[ii * 3 + 2];

                Vector3 pt0 = new Vector3(points[p0 * 3], points[p0 * 3 + 1], points[p0 * 3 + 2]);
                Vector3 pt1 = new Vector3(points[p1 * 3], points[p1 * 3 + 1], points[p1 * 3 + 2]);
                Vector3 pt2 = new Vector3(points[p2 * 3], points[p2 * 3 + 1], points[p2 * 3 + 2]);

                // ....
                // use the same way to get the normal data for each point.
            }
             * */
            //////////////////////////////////////////////////////////////////////////
        }

        private void pickNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.SetPickMode((int)(EnumPickMode.RF_SceneNode | EnumPickMode.RF_Face));
        }

        private void pickGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.SetPickMode((int)(EnumPickMode.RF_GroupSceneNode | EnumPickMode.RF_Face));

            // Test Group
            TopoShape cylinder = GlobalInstance.BrepTools.MakeCylinder(Vector3.ZERO, Vector3.UNIT_Z, 50, 100, 0);
            TopoShape sphere = GlobalInstance.BrepTools.MakeSphere(new Vector3(0, 0, 150), 50);

            GroupSceneNode group = new GroupSceneNode();
            group.AddNode(GlobalInstance.TopoShapeConvert.ToEntityNode(cylinder, 0.1f));
            group.AddNode(GlobalInstance.TopoShapeConvert.ToEntityNode(sphere, 0.1f));

            renderView.SceneManager.AddNode(group);

        }

        private void pickFaceEdgePointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderView.View3d.SetPickMode((int)(EnumPickMode.RF_Default));
        }

        private bool mShowGrid = true;
        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mShowGrid = !mShowGrid;
            renderView.View3d.ShowWorkingGrid(mShowGrid);
            renderView.RequestDraw();
        }

        private void projLineToSurfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vector3List points = new Vector3List();
            points.Add(new Vector3(0, 0, 0));
            points.Add(new Vector3(50, 0, 0));
            points.Add(new Vector3(100, 0, 0));

            points.Add(new Vector3(0, 50, 0));
            points.Add(new Vector3(50, 50, 5));
            points.Add(new Vector3(100, 50, -5));

            points.Add(new Vector3(0, 150, 5));
            points.Add(new Vector3(50, 150, -5));
            points.Add(new Vector3(100, 150, 0));

            TopoShape surface = GlobalInstance.BrepTools.MakeSurfaceFromPoints(points, 3, 3);

            TopoShape line = GlobalInstance.BrepTools.MakeLine(new Vector3(0, 0, 200), new Vector3(100, 150, 200));

            TopoShape proj = GlobalInstance.BrepTools.ProjectOnSurface(line, surface);

            renderView.ShowGeometry(proj, 200);
            renderView.ShowGeometry(surface, 200);
            renderView.RequestDraw();
        }

        private void largePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const float len = 100.0f;
            const int nDim = 50;
            float[] pointBuffer = new float[nDim * nDim * nDim * 3];
            int idx = -1;
            for (int ii = 0; ii < nDim; ++ii)
                for (int jj = 0; jj < nDim; ++jj)
                    for (int kk = 0; kk < nDim; ++kk)
                    {
                        ++idx;
                        pointBuffer[idx * 3] = ii * len;
                        pointBuffer[idx * 3 + 1] = jj * len;
                        pointBuffer[idx * 3 + 2] = kk * len;
                    }

            PointStyle pointStyle = new PointStyle();
            pointStyle.SetPointSize(4.0f);
            pointStyle.SetColor(new ColorValue(0.0f, 0.0f, 0.0f));

            PointCloudNode pcn = new PointCloudNode();
            pcn.SetPointStyle(pointStyle);
            pcn.SetPoints(pointBuffer);
            pcn.ComputeBBox();

            renderView.SceneManager.AddNode(pcn);

            renderView.RequestDraw();
        }

        private void chamferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape box = GlobalInstance.BrepTools.MakeBox(Vector3.ZERO, Vector3.UNIT_Z, new Vector3(100, 100, 100));

            // Simple
            {
                TopoShape chamfer1 = GlobalInstance.BrepTools.Chamfer(box, 10, 10);
                renderView.ShowGeometry(chamfer1, 200);
            }
            // Complex: only chamfer the specified edge
            {
                int[] edgeIndex = { 0, 2 };
                float[] dis1 = { 10, 5 };
                float[] dis2 = { 12, 12 };
                TopoShape chamfer2 = GlobalInstance.BrepTools.MakeChamfer(box, edgeIndex, dis1, dis2);
                SceneNode node =  renderView.ShowGeometry(chamfer2, 201);

                Matrix4 trf = GlobalInstance.MatrixBuilder.MakeTranslate(new Vector3(200, 0, 0));
                node.SetTransform(trf);
            }

            renderView.RequestDraw();
        }

        private void filletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopoShape box = GlobalInstance.BrepTools.MakeBox(Vector3.ZERO, Vector3.UNIT_Z, new Vector3(100, 100, 100));

            // Simple
            {
                TopoShape fillet1 = GlobalInstance.BrepTools.Fillet(box, 10);
                renderView.ShowGeometry(fillet1, 200);
            }
            // Complex: only fillet the specified edge
            {
                int[] edgeIndex = { 0, 2 };
                float[] radius = { 10, 5 };
                TopoShape fillet2 = GlobalInstance.BrepTools.MakeFillet(box, edgeIndex, radius);
                SceneNode node = renderView.ShowGeometry(fillet2, 201);

                Matrix4 trf = GlobalInstance.MatrixBuilder.MakeTranslate(new Vector3(200, 0, 0));
                node.SetTransform(trf);
            }

            renderView.RequestDraw();
        }
    }
}
