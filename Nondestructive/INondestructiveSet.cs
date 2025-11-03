public interface INondestructiveSet<T> {
    INondestructiveSet<T> Intersection(INondestructiveSet<T> other);
    INondestructiveSet<T> Union(INondestructiveSet<T> other);
    INondestructiveSet<T> Difference(INondestructiveSet<T> other);
}