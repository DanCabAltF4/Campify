package org.example.persistence;

import jakarta.persistence.EntityManager;
import jakarta.persistence.EntityManagerFactory;
import jakarta.persistence.Persistence;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class ConexionDB {

    //Atributos de clase
    private static final String JDBC_USER = "root";
    private static final String JDBC_PASS = "mysql";
    private static final String JDBC_URL = "jdbc:mysql://localhost:3306/";
    private static final String NOMBRE_DB = "campifyDB";

    //Atributos de instancia
    private EntityManagerFactory emf;
    private static ConexionDB instance;

    private ConexionDB() {
        try {
            emf = Persistence.createEntityManagerFactory("PersistenceUnit");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static ConexionDB getInstance() {
        if (instance == null) {
            instance = new ConexionDB();
        }
        return instance;
    }

    //Conexión por JPA
    public EntityManager getConexion() {
        return emf.createEntityManager();
    }

    //Conexión JDBC para crear DB al inicio
    public Connection getConexionJDBC() {
        Connection con = null;
        try {
            con = DriverManager.getConnection(JDBC_URL, JDBC_USER, JDBC_PASS);
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return con;
    }

    //Metodo para crear base de datos al inicio del programa
    public static void crearBaseDatos() {
        String sql = "CREATE DATABASE IF NOT EXISTS " + NOMBRE_DB;
        try (Connection con = DriverManager.getConnection(JDBC_URL, JDBC_USER, JDBC_PASS);
                PreparedStatement st = con.prepareStatement(sql);) {
            st.execute(sql);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
