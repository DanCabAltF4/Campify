package org.example.persistence;

public interface IDAO<T,ID>{
    void insert(T t);
    void update(T t);
    void delete(T t);
    T findById(ID id);
}
