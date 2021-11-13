using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.AI.Planner.Traits;

namespace Generated.AI.Planner.StateRepresentation
{
    [Serializable]
    public struct cop : ITrait, IBufferElementData, IEquatable<cop>
    {

        public void SetField(string fieldName, object value)
        {
        }

        public object GetField(string fieldName)
        {
            throw new ArgumentException("No fields exist on trait cop.");
        }

        public bool Equals(cop other)
        {
            return true;
        }

        public override string ToString()
        {
            return $"cop";
        }
    }
}
