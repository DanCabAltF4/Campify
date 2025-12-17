package org.example.controller;

import org.example.model.Cliente;
import org.example.service.ClienteService;
import org.springframework.web.bind.annotation.*;


@RestController
@RequestMapping("/api/clientes")
public class ClienteController {

    private ClienteService service;

    public ClienteController(ClienteService service){
        this.service=service;
    }

    @PostMapping
    public Cliente insert(@RequestBody Cliente cliente){
        return service.insert(cliente);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Cliente update(@PathVariable int id, @RequestBody Cliente cliente){
        return service.update(id, cliente);
    }

    @GetMapping("/{id}")
    public Cliente findById(@PathVariable int id){
        return service.findById(id);
    }
}
