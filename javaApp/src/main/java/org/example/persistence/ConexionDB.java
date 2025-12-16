package org.example.persistence;

import jakarta.persistence.EntityManager;
import jakarta.persistence.EntityManagerFactory;
import jakarta.persistence.Persistence;

public class ConexionDB {

    private EntityManagerFactory emf;
    private static ConexionDB instance;

    private ConexionDB(){
        try{
            emf= Persistence.createEntityManagerFactory("PersistenceUnit");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public EntityManager getConexion(){
        return emf.createEntityManager();
    }

    public static ConexionDB getInstance(){
        if(instance==null){
            instance= new ConexionDB();
        }
        return instance;
    }
}
