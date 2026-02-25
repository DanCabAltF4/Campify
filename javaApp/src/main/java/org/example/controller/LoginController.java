package org.example.controller;

import org.example.dto.LoginRequest;
import org.example.dto.LoginResponse;
import org.example.model.Empleado;
import org.example.service.ServiceLogin;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/auth")
public class LoginController {

    private final ServiceLogin service;

    public LoginController(ServiceLogin service) {
        this.service = service;
    }

    @PostMapping("/login")
    public ResponseEntity<LoginResponse> login(@RequestBody LoginRequest loginRequest) {

        Empleado emp = service.validarLogin(loginRequest.email(), loginRequest.password());

        if (emp == null) {
            return ResponseEntity.status(403).build();
        }

        String token = service.generarToken(emp);
        return ResponseEntity.ok(new LoginResponse(token, emp.getPuesto(), emp.getId()));
    }
}
