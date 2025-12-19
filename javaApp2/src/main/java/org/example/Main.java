package org.example;

import jakarta.persistence.EntityManager;
import jakarta.persistence.EntityManagerFactory;
import org.example.persistence.ConexionDB;

import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        EntityManagerFactory emf = ConexionDB.getInstance().getConexion().getEntityManagerFactory();
        EntityManager em = emf.createEntityManager();


        int opcion;
        do {
            System.out.println("1.");
            System.out.println("2. ");
            System.out.println("3. ");
            System.out.println("4. ");
            System.out.println("0. Salir");
            System.out.print("Opción: ");
            opcion = new Scanner(System.in).nextInt();
            switch (opcion) {
                // case 1 -> ;
                // case 2 -> ;
                // case 3 -> ;
                // case 4 -> ;
                // case 0 -> System.out.println("Saliendo...");
                // default -> System.out.println("Opción no válida.");
            }
        } while (opcion != 0);
        // ConexionDB.CerrarConexion(emf);
    }
}