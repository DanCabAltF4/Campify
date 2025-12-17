package org.example.persistence;

import jakarta.persistence.EntityManager;
import org.example.model.Empleado;

public class EmpleadoDAO implements IDAOEmpleado {

    @Override
    public void insert(Empleado empleado) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.persist(empleado);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void update(Empleado empleado) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.merge(empleado);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void delete(Empleado empleado) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.remove(empleado);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public Empleado findById(Integer integer) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        Empleado empleado = null;
        try{
            empleado = em.find(Empleado.class, integer);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
        return empleado;
    }
}
