package org.example.controller;

import org.example.model.Estancia;
import org.example.service.ServiceEstancia;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/estancias")
public class EstanciaController {

    private ServiceEstancia service;

    public EstanciaController(ServiceEstancia service) {
        this.service = service;
    }

    @PostMapping
    public Estancia insert (@RequestBody Estancia estancia){
        return service.insert(estancia);
    }

    @DeleteMapping("/{id}")
    public void delete (@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Estancia update (@PathVariable int id, @RequestBody Estancia estancia){
        return service.update(id, estancia);
    }

    @GetMapping("/{id}")
    public Estancia findById(@PathVariable  int id){
        return service.findById(id);
    }

    @GetMapping
    public List<Estancia> findAll(){
        return service.findAll();
    }
}
