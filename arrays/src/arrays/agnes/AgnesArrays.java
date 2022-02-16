package arrays.agnes;

public class AgnesArrays {
    public int [] array;
    int count;

    public AgnesArrays(int length)
    {
        count = 0;
        array = new int[length];
    }
    public void insert(int element) {
        if(array.length == count)
        {
            int [] newArray = new int[count*2];
            for (int i = 0; i < count; i++) {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        array[count] = element;
        count++;
    }
    public void removeAt(int index) {
        if(index < 0 || index >= count)
            throw new IllegalArgumentException();
        for (int i = index; i < count; i++) {
            array[i] = array[i+1];
        }
        count--;
    }
    public int indexOf(int element)
    {
        int index = -1;
        for (int i = 0; i < count; i++) {
            if (array[i]==element)
                index = i;
        }
        return  index;
    }
    public void print(){
        for (int i = 0; i < count; i++) {
            System.out.println(array[i]);
        }
    }

}
