package org.example.persistence;

import jakarta.persistence.EntityManager;
import org.example.model.Servicio;

public class ServicioDAO implements IServicioDAO {

    @Override
    public void insert(Servicio servicio) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.persist(servicio);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void update(Servicio servicio) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.merge(servicio);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void delete(Servicio servicio) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.remove(servicio);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public Servicio findById(Integer integer) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        Servicio servicio = null;
        try{
            servicio = em.find(Servicio.class, integer);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
        return servicio;
    }
}
