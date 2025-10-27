public interface IDynamicArray<T> {
    void Append(T element);
    void Insert(T element, int index);
    void Remove(int i);
    void Set(int i, T element);
    T Get(int i);
    int GetFill();  
}