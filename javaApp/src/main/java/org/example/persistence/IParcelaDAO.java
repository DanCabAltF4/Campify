package org.example.persistence;

import jakarta.persistence.EntityManager;
import org.example.dao.ParcelaDAO;
import org.example.model.Parcela;

public class IParcelaDAO implements ParcelaDAO {
    @Override
    public void insert(Parcela parcela) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.persist(parcela);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void update(Parcela parcela) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.merge(parcela);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void delete(Parcela parcela) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.remove(parcela);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public Parcela findById(Integer integer) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        Parcela parcela = null;
        try{
            parcela = em.find(Parcela.class, integer);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
        return parcela;
    }
}
