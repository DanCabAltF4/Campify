package org.example.service;

public interface IService<T, Integer> {
    T insert(T t);
    T update (int id, T t);
    void delete (int id);
    T findById(int id);

}
