package org.example.controller;

import org.example.model.Empleado;
import org.example.service.ServiceEmpleado;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/empleados")
class EmpleadoController {

    private final ServiceEmpleado service;

    public EmpleadoController(ServiceEmpleado service) {
        this.service = service;
    }

    @PostMapping
    public Empleado insert(@RequestBody Empleado empleado){
        return service.insert(empleado);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable int id){
        service.delete(id);
    }

    @PutMapping("/{id}")
    public Empleado update(@PathVariable int id, @RequestBody Empleado empleado){
        return service.update(id,empleado);
    }

    @GetMapping("/{id}")
    public Empleado findById(@PathVariable int id){
        return service.findById(id);
    }

    @GetMapping
    public List<Empleado> findAll(){
        return service.findAll();
    }
}
