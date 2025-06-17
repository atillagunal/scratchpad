/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.learningjava;

import java.util.Scanner;
import java.util.ArrayList;

/**
 *
 * @author gunal
 */
public class Learningjava {

    public static void main(String[] args)
    {
        /*
        System.out.println("Hello World!");
        System.out.println("Enter your name:");
        
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        
        System.out.println("Hello " + name);
        */
        
        ArrayList<Integer> numbers = new ArrayList<>();
        numbers.add(1);
        numbers.add(2);
        numbers.add(3);
        numbers.add(4);
        numbers.add(5);
        numbers.remove(3);
                
        System.out.println(numbers);
    }
}
