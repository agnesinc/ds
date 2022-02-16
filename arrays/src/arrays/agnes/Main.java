package arrays.agnes;

import java.util.Arrays;

public class Main {

    public static void main(String[] args) {
	    AgnesArrays array = new AgnesArrays(3);

        array.insert(8);
        array.insert(7);
        array.insert(6);
        array.insert(5);

        System.out.println( array.indexOf(22));
        array.print();
    }
}
