package org.example.persistence;

import org.example.model.Estancia;
import org.springframework.data.jpa.repository.JpaRepository;

public interface EstanciaRepository extends JpaRepository<Estancia,Integer> {
}
