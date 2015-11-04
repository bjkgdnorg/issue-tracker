﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARUP.IssueTracker.Classes
{
    // 
    // This source code was auto-generated by xsd, Version=4.0.30319.33440.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class VisualizationInfo
    {

        private Component[] componentsField;

        private OrthogonalCamera orthogonalCameraField;

        private PerspectiveCamera perspectiveCameraField;

        private SheetCamera sheetCameraField; //CASE

        private Line[] linesField;

        private ClippingPlane[] clippingPlanesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public Component[] Components
        {
            get
            {
                return this.componentsField;
            }
            set
            {
                this.componentsField = value;
            }
        }

        /// <remarks/>
        public OrthogonalCamera OrthogonalCamera
        {
            get
            {
                return this.orthogonalCameraField;
            }
            set
            {
                this.orthogonalCameraField = value;
            }
        }

        /// <remarks/>
        public PerspectiveCamera PerspectiveCamera
        {
            get
            {
                return this.perspectiveCameraField;
            }
            set
            {
                this.perspectiveCameraField = value;
            }
        }

        /// <remarks/>
        public SheetCamera SheetCamera
        {
            get
            {
                return this.sheetCameraField;
            }
            set
            {
                this.sheetCameraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public Line[] Lines
        {
            get
            {
                return this.linesField;
            }
            set
            {
                this.linesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public ClippingPlane[] ClippingPlanes
        {
            get
            {
                return this.clippingPlanesField;
            }
            set
            {
                this.clippingPlanesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Component
    {

        private string originatingSystemField;

        private string authoringToolIdField;

        private string ifcGuidField;
        public Component() { }
        public Component(string os, string aid, string guid)
        {
            OriginatingSystem = os;
            authoringToolIdField = aid;
            IfcGuid = guid;
        }

        /// <remarks/>
        public string OriginatingSystem
        {
            get
            {
                return this.originatingSystemField;
            }
            set
            {
                this.originatingSystemField = value;
            }
        }

        /// <remarks/>
        public string AuthoringToolId
        {
            get
            {
                return this.authoringToolIdField;
            }
            set
            {
                this.authoringToolIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string IfcGuid
        {
            get
            {
                return this.ifcGuidField;
            }
            set
            {
                this.ifcGuidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ClippingPlane
    {

        private Point locationField;

        private Direction directionField;

        /// <remarks/>
        public Point Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public Direction Direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Point
    {

        private double xField;

        private double yField;

        private double zField;

        public Point()
        {
        }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <remarks/>
        public double X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public double Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public double Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Direction
    {

        private double xField;

        private double yField;

        private double zField;

        /// <remarks/>
        public double X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public double Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public double Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Line
    {

        private Point startPointField;

        private Point endPointField;

        /// <remarks/>
        public Point StartPoint
        {
            get
            {
                return this.startPointField;
            }
            set
            {
                this.startPointField = value;
            }
        }

        /// <remarks/>
        public Point EndPoint
        {
            get
            {
                return this.endPointField;
            }
            set
            {
                this.endPointField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PerspectiveCamera
    {

        private Point cameraViewPointField;

        private Direction cameraDirectionField;

        private Direction cameraUpVectorField;

        private double fieldOfViewField;
        public PerspectiveCamera()
        {
            CameraViewPoint = new Point();
            CameraDirection = new Direction();
            CameraUpVector = new Direction();


        }

        /// <remarks/>
        public Point CameraViewPoint
        {
            get
            {
                return this.cameraViewPointField;
            }
            set
            {
                this.cameraViewPointField = value;
            }
        }

        /// <remarks/>
        public Direction CameraDirection
        {
            get
            {
                return this.cameraDirectionField;
            }
            set
            {
                this.cameraDirectionField = value;
            }
        }

        /// <remarks/>
        public Direction CameraUpVector
        {
            get
            {
                return this.cameraUpVectorField;
            }
            set
            {
                this.cameraUpVectorField = value;
            }
        }

        /// <remarks/>
        public double FieldOfView
        {
            get
            {
                return this.fieldOfViewField;
            }
            set
            {
                this.fieldOfViewField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OrthogonalCamera
    {

        private Point cameraViewPointField;

        private Direction cameraDirectionField;

        private Direction cameraUpVectorField;

        private double viewToWorldScaleField;

        public OrthogonalCamera()
        {
            CameraViewPoint = new Point();
            CameraDirection = new Direction();
            CameraUpVector = new Direction();


        }

        /// <remarks/>
        public Point CameraViewPoint
        {
            get
            {
                return this.cameraViewPointField;
            }
            set
            {
                this.cameraViewPointField = value;
            }
        }

        /// <remarks/>
        public Direction CameraDirection
        {
            get
            {
                return this.cameraDirectionField;
            }
            set
            {
                this.cameraDirectionField = value;
            }
        }

        /// <remarks/>
        public Direction CameraUpVector
        {
            get
            {
                return this.cameraUpVectorField;
            }
            set
            {
                this.cameraUpVectorField = value;
            }
        }

        /// <remarks/>
        public double ViewToWorldScale
        {
            get
            {
                return this.viewToWorldScaleField;
            }
            set
            {
                this.viewToWorldScaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SheetCamera
    {

        private Point topLeft;

        private Point bottomRight;

        private int sheetID;

        public SheetCamera()
        {
            TopLeft = new Point();
            BottomRight = new Point();
        }

        /// <remarks/>
        public Point TopLeft
        {
            get
            {
                return this.topLeft;
            }
            set
            {
                this.topLeft = value;
            }
        }

        /// <remarks/>
        public Point BottomRight
        {
            get
            {
                return this.bottomRight;
            }
            set
            {
                this.bottomRight = value;
            }
        }

        /// <remarks/>
        public int SheetID
        {
            get
            {
                return this.sheetID;
            }
            set
            {
                this.sheetID = value;
            }
        }
    }
}