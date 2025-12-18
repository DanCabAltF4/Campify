package org.example.persistence;

import jakarta.persistence.EntityManager;
import org.example.dao.ClienteDAO;
import org.example.model.Cliente;

public class IClienteDAO implements ClienteDAO {

    @Override
    public void insert(Cliente cliente) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.persist(cliente);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void update(Cliente cliente) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.merge(cliente);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public void delete(Cliente cliente) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        try{
            em.getTransaction().begin();
            em.remove(cliente);
            em.getTransaction().commit();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
    }

    @Override
    public Cliente findById(Integer integer) {
        EntityManager em = ConexionDB.getInstance().getConexion();
        Cliente cliente = null;
        try{
            cliente = em.find(Cliente.class, integer);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }finally{
            em.close();
        }
        return cliente;
    }
}
