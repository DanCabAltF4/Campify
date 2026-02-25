package org.example.persistence;

import org.example.model.Estancia;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.time.LocalDate;

public interface EstanciaRepository extends JpaRepository<Estancia,Integer> {
}
