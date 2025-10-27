public class DynamicArray<T> : IDynamicArray<T> {
    private T[] data;
    private int capacity;
    private int fill;

    private const int RESIZE = 1;

    public DynamicArray(int size) {
        data = new T[size];
        capacity = size;
        fill = 0;
    }

    public void Append(T element) {
        if (fill == capacity) IncreaseArray();
        data[fill++] = element;
    }

    public T Get(int i) {
        if (i < capacity - 1) {
            return data[i];
        } else {
            return default!;
        }
    }

    public int GetFill() {
        return fill;
    }

    public void Insert(T element, int index) {
        if (fill == capacity) IncreaseArray();
        if (index > capacity) return; // No spaces. Error

        for (int i = fill; i > index; i--) {
            data[i] = data[i-1];
        }

        data[index] = element;
        fill++;
    }

    public void Remove(int index) {
        if (index > data.Length - 1) return;
        
        T[] newArray = new T[capacity];
        int newIndex = 0;
        for (int i = 0; i < data.Length; i++) {
            if (i == index) {
                fill -= 1;
                continue;
            }
            newArray[newIndex++] = data[i];
        }

        data = newArray;

        if (fill < capacity - RESIZE) {
            DecreaseArray();
        }
    }

    public void Set(int i, T element) {
        if (i > capacity - 1) return;
        data[i] = element;
    }

    private void IncreaseArray() {
        capacity += RESIZE;

        T[] newArray = new T[capacity];
        for (int i = 0; i < data.Length; i++) {
            newArray[i] = data[i];
        }
        data = newArray;
    }

    private void DecreaseArray() {
        capacity -= RESIZE;

        T[] newArray = new T[capacity];
        for (int i = 0; i < capacity; i++) {
            newArray[i] = data[i];
        }
        data = newArray;
    }

    public override string ToString() {
        string text = "";
        for (int i = 0; i < data.Length; i++) {
            text += data[i] + " ";
        }

        return text;
    }
}