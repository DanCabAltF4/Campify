package org.example.persistence;

import jakarta.persistence.EntityManager;
import org.example.dao.EstanciaDAO;
import org.example.model.Estancia;

public class IEstanciaDAO implements EstanciaDAO {
    @Override
    public void insert(Estancia estancia) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.persist(estancia);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void update(Estancia estancia) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.merge(estancia);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void delete(Estancia estancia) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.remove(estancia);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public Estancia findById(Integer integer) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        Estancia estancia = null;
        try{
            estancia = em.find(Estancia.class, integer);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
        return estancia;
    }
}
