package org.example.service;

import org.example.model.Empleado;
import org.example.persistence.EmpleadoRepository;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.oauth2.jose.jws.MacAlgorithm;
import org.springframework.security.oauth2.jwt.*;
import org.springframework.stereotype.Service;

import java.time.Instant;

@Service
public class ServiceLogin {

    private final EmpleadoRepository empleadoRepository;
    private final PasswordEncoder passwordEncoder;
    private final JwtEncoder jwtEncoder;

    @Value("${security.jwt.issuer}")
    private String issuer;

    public ServiceLogin(EmpleadoRepository empleadoRepository, PasswordEncoder passwordEncoder, JwtEncoder jwtEncoder) {
        this.empleadoRepository = empleadoRepository;
        this.passwordEncoder = passwordEncoder;
        this.jwtEncoder = jwtEncoder;
    }

    public Empleado validarLogin(String email, String password) {
        Empleado emp = empleadoRepository.findByEmail(email).orElse(null);
        if (emp == null) return null;

        // bloquear login si no está activo
        if (!emp.isActivo()) return null;

        if (!passwordEncoder.matches(password, emp.getPassword())) return null;

        return emp;
    }

    public String generarToken(Empleado emp) {
        Instant now = Instant.now();
        JwtClaimsSet claims = JwtClaimsSet.builder()
                .issuer(issuer)
                .issuedAt(now)
                .expiresAt(now.plusSeconds(60 * 60 * 12)) // token de 12 horas
                .subject(emp.getEmail())
                .claim("rol", emp.getPuesto().name()) // meto claim pra filtrado por roles
                .claim("userId", emp.getId())
                .build();

        JwsHeader header = JwsHeader.with(MacAlgorithm.HS256).build();
        return jwtEncoder.encode(JwtEncoderParameters.from(header, claims)).getTokenValue();
    }
}
