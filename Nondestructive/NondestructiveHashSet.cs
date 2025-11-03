public class NondestructiveHashSet<T> : HashSet<T>, INondestructiveSet<T> {
    
    public INondestructiveSet<T> Difference(INondestructiveSet<T> other) {
        INondestructiveSet<T> result;
 
    }

    public INondestructiveSet<T> Intersection(INondestructiveSet<T> other)
    {
        throw new NotImplementedException();
    }

    public INondestructiveSet<T> Union(INondestructiveSet<T> other)
    {
        throw new NotImplementedException();
    }
}