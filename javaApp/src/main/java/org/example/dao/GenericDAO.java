package org.example.dao;

public interface GenericDAO <T,ID>{
    void insert(T t);
    void update(T t);
    void delete(T t);
    T findById(ID id);
}
