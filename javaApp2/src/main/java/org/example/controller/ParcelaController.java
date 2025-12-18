package org.example.controller;

import org.example.model.Parcela;
import org.example.service.ServiceParcela;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("api/parcelas")
public class ParcelaController {
    private ServiceParcela service;

    public ParcelaController(ServiceParcela service) {
        this.service = service;
    }

    @RequestMapping
    public Parcela insert (@RequestBody Parcela parcela){
        return service.insert(parcela);
    }

    @DeleteMapping("/{id}")
    public void delete (@PathVariable int id){
        service.delete(id);
    }

    @RequestMapping("/{id}")
    public Parcela update (@PathVariable int id, @RequestBody Parcela parcela){
        return service.update(id, parcela);
    }

    @GetMapping("/{id}")
    public Parcela findById(@RequestParam int id){
        return service.findById(id);
    }


}
