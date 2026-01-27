package org.example.controller;

import org.example.model.Servicio;
import org.example.service.ServiceServicio;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/servicios")
public class ServicioController {

    private final ServiceServicio service;

    public ServicioController(ServiceServicio service){
        this.service=service;
    }

    @GetMapping("/{id}")
    public Servicio findById(@PathVariable int id){
        return service.findById(id);
    }

    @GetMapping
    public List<Servicio> findAll(){
        return service.findAll();
    }

    @PostMapping
    public Servicio insert(@RequestBody Servicio servicio){
        return service.insert(servicio);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Servicio update(@PathVariable int id,@RequestBody Servicio servicio){
        return service.update(id, servicio);
    }
}
