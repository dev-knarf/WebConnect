using System;

namespace WebConnect.Data.Model
{
    public abstract class AbstractModel : AbstractModel<int>{}

    public abstract class AbstractModel<TId>
    {
        public TId ObjectId { get; set; }

        public DateTime CreationDate { get; set; }

        //private static bool IsTransient(AbstractModel<TId> obj) => 
        //    obj != null && Equals(obj.ObjectId, default(TId));
        
        //private Type GetUnproxiedType() => GetType();

        //public virtual bool Equals(AbstractModel<TId> obj)
        //{
        //    if (obj == null) return false;
        //    if (ReferenceEquals(this, obj)) return true;
        //    if (IsTransient(this) || IsTransient(obj) || !Equals(ObjectId, obj.ObjectId)) return false;
        //    return GetUnproxiedType().IsAssignableFrom(obj.GetUnproxiedType()) ||
        //           obj.GetUnproxiedType().IsAssignableFrom(GetUnproxiedType());
        //}

        //public override bool Equals(object obj) => Equals(obj as AbstractModel<TId>);
        
        //public override int GetHashCode() => 
        //    Equals(ObjectId, default(TId)) ? base.GetHashCode() : ObjectId.GetHashCode();
    }
}
