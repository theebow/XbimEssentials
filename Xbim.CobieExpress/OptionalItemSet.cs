// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using Xbim.Common;

namespace Xbim.CobieExpress
{
    public class OptionalItemSet<T>: ItemSet<T>, IOptionalItemSet<T>
    {
        private bool _initialized;

        internal OptionalItemSet(IPersistEntity entity, int capacity, int property) : base(entity, capacity, property)
        {
        }

        public bool Initialized 
		{ 
            get { return _initialized || Count > 0; }
		}

        public void Initialize()
        {
            _initialized = true;
        }

        public void Uninitialize()
        {
            Clear();
            _initialized = false;
        }
    }
}
