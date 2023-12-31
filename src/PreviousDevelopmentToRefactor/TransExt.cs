﻿using Autodesk.AutoCAD.DatabaseServices;

namespace PreviousDevelopmentToRefactor
{
    public static class TransExt
    {
        public static DBObject GetObjectForRead(this Transaction acTrans, ObjectId id)
        {
            return acTrans.GetObject(id, OpenMode.ForRead);
        }

        public static DBObject GetObjectForWrite(this Transaction acTrans, ObjectId id)
        {
            return acTrans.GetObject(id, OpenMode.ForWrite);
        }
    }
}