﻿namespace System.IO.BACnet
{
    public struct BacnetPropertyReference
    {
        public uint propertyIdentifier;
        public uint propertyArrayIndex;        /* optional */

        public BacnetPropertyReference(uint id, uint arrayIndex)
        {
            propertyIdentifier = id;
            propertyArrayIndex = arrayIndex;
        }

        public override string ToString()
        {
            return ((BacnetPropertyIds)propertyIdentifier).ToString();
        }
    }
}