package org.example.security;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.convert.converter.Converter;
import org.springframework.http.HttpMethod;
import org.springframework.security.authentication.AbstractAuthenticationToken;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.http.SessionCreationPolicy;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.oauth2.jwt.Jwt;
import org.springframework.security.oauth2.server.resource.authentication.JwtAuthenticationToken;
import org.springframework.security.web.SecurityFilterChain;

import java.util.List;

@Configuration
@EnableWebSecurity
public class SecurityConfig {

    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {

        http
                .csrf(csrf -> csrf.disable())
                .sessionManagement(sm -> sm.sessionCreationPolicy(SessionCreationPolicy.STATELESS))

                // IMPORTANTE: esto hace que se use tu jwtAuthenticationConverter()
                .oauth2ResourceServer(oauth2 -> oauth2
                        .jwt(jwt -> jwt.jwtAuthenticationConverter(jwtAuthenticationConverter()))
                )

                .authorizeHttpRequests(auth -> auth

                        // ====== LOGIN PUBLICO ======
                        .requestMatchers("/api/auth/**").permitAll()

                        // ====== EMPLEADOS (solo ADMIN) ======
                        // RECEPCIONISTA puede consultar empleado por ID (para poder editar estancias)
                        .requestMatchers(HttpMethod.GET, "/api/empleados/*")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")

                        // El resto de peticiones de empleados solo para ADMIN
                        .requestMatchers("/api/empleados/**").hasRole("ADMINISTRADOR")

                        // ====== CLIENTES ======
                        .requestMatchers(HttpMethod.GET, "/api/clientes/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")
                        .requestMatchers(HttpMethod.POST, "/api/clientes/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")
                        .requestMatchers(HttpMethod.PUT, "/api/clientes/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")
                        .requestMatchers(HttpMethod.DELETE, "/api/clientes/**")
                        .hasRole("ADMINISTRADOR")

                        // ====== SERVICIOS ======
                        .requestMatchers(HttpMethod.GET, "/api/servicios/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA", "CAMPO")
                        .requestMatchers(HttpMethod.POST, "/api/servicios/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")
                        .requestMatchers(HttpMethod.PUT, "/api/servicios/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")
                        .requestMatchers(HttpMethod.DELETE, "/api/servicios/**")
                        .hasRole("ADMINISTRADOR")

                        // ====== ESTANCIAS ======
                        .requestMatchers(HttpMethod.GET, "/api/estancias/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA", "CAMPO")
                        .requestMatchers(HttpMethod.POST, "/api/estancias/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")
                        .requestMatchers(HttpMethod.PUT, "/api/estancias/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")
                        .requestMatchers(HttpMethod.DELETE, "/api/estancias/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA")

                        // ====== PARCELAS ======
                        .requestMatchers(HttpMethod.GET, "/api/parcelas/**")
                        .hasAnyRole("ADMINISTRADOR", "RECEPCIONISTA", "CAMPO")
                        .requestMatchers(HttpMethod.POST, "/api/parcelas/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.DELETE, "/api/parcelas/**")
                        .hasRole("ADMINISTRADOR")
                        .requestMatchers(HttpMethod.PUT, "/api/parcelas/**")
                        .hasAnyRole("ADMINISTRADOR")

                        .anyRequest().authenticated()
                );

        return http.build();
    }

    @Bean
    public Converter<Jwt, ? extends AbstractAuthenticationToken> jwtAuthenticationConverter() {
        return jwt -> {
            String rol = jwt.getClaimAsString("rol"); // claim rol del token
            var authorities = List.of(new SimpleGrantedAuthority("ROLE_" + rol));
            return new JwtAuthenticationToken(jwt, authorities);
        };
    }
}
