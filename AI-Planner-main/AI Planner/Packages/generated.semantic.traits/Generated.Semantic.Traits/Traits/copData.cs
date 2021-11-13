using System;
using System.Collections.Generic;
using Unity.Semantic.Traits;
using Unity.Collections;
using Unity.Entities;

namespace Generated.Semantic.Traits
{
    [Serializable]
    public partial struct copData : ITraitData, IEquatable<copData>
    {

        public bool Equals(copData other)
        {
            return true;
        }

        public override string ToString()
        {
            return $"cop";
        }
    }
}
