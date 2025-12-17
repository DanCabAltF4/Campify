package org.example.service;

public interface IService<T, Integer> {
    void insert(T t);
    void update (T t);
    void delete (T t);
    T findById(int id);

}
