﻿using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using DDNCADAddins.Environments;

namespace DDNCADAddins.Cropper
{
    public class MTextCropper : EntityCropper<MText>
    {
        public MTextCropper(MText entity, Curve boundary, WhichSideToKeep whichSideToKeep,
            CommandTransBase commandTransBase) : base(entity, boundary, whichSideToKeep, commandTransBase)
        {
        }


        internal override Point3d GetPosition()
        {
            return _entity.Location;
        }
    }
}