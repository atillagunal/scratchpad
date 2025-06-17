/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.learningjava;

import java.util.Scanner;

/**
 *
 * @author gunal
 */
public class Learningjava {

    public static void main(String[] args)
    {
        System.out.println("Hello World!");
        
        System.out.println("Enter your name:");
        
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        
        System.out.println("Hello " + name);
    }
}
