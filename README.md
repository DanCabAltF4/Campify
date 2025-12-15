# 🏕️ Campify

**Campify** es un gestor integral de campings diseñado para **optimizar y agilizar la asignación de parcelas**, especialmente en momentos de alta carga de trabajo donde la comunicación entre el personal puede fallar.

El proyecto surge a partir de la experiencia real trabajando en un camping, donde problemas habituales como walkie-talkies defectuosos, ruido ambiental o falta de coordinación podían provocar errores críticos, como asignar la misma parcela a varios clientes o indicar parcelas que no estaban realmente disponibles.

---

## 🚀 Objetivo del proyecto

Mejorar la **coordinación entre recepción y personal de campo**, garantizando información en tiempo real sobre el estado de las parcelas y reduciendo errores humanos en situaciones caóticas.

---

## 🧩 Arquitectura del sistema

Campify está compuesto por tres elementos principales:

- **Aplicación de escritorio** (recepción)
- **Aplicación móvil** (personal del camping)
- **Base de datos centralizada**

Todos los componentes están sincronizados para reflejar los cambios en tiempo real.

---

## 🗺️ Gestión de parcelas

Tanto en la aplicación de escritorio como en la móvil se puede consultar un **listado y/o mapa de parcelas**, cada una con uno de los siguientes estados:

- 🟢 Libre  
- 🔴 Ocupada  
- 🟡 Reservada  
- 🔵 Cliente interesado  

### 📱 Aplicación móvil

Pensada para el personal que acompaña a los clientes a las parcelas:

- Visualización del estado actualizado de todas las parcelas.
- Marcar parcelas libres como **cliente interesado**.
- Sincronización automática con:
  - La aplicación de escritorio.
  - Las aplicaciones móviles del resto de compañeros.
- Posibilidad de marcar parcelas para reservas futuras si la estancia actual no se extiende hasta la fecha de la reserva.

### 🖥️ Aplicación de escritorio (recepción)

Utilizada por el personal de recepción para la gestión principal del camping:

- **Check-in** (Libre → Ocupada)
- **Check-out** (Ocupada → Libre)
- Gestión de **reservas** (Libre → Reservada)
- **Cambios de parcela**
- Visualización global del estado del camping en tiempo real.

---

## 👤 Gestión de clientes

El sistema permite crear y gestionar **fichas de cliente**, incluyendo:

- Información básica del cliente.
- Datos de identificación requeridos por la **Guardia Civil**.
- Notas internas asociadas a cada cliente.

La base de datos de los clientes alojados en el camping puede **exportarse y enviarse periódicamente a la Guardia Civil**, cumpliendo con los requisitos legales vigentes.

---

## 🛡️ Ventajas principales

- Reducción de errores en la asignación de parcelas.
- Información centralizada y actualizada en tiempo real.
- Menor dependencia de sistemas de comunicación por voz.
- Mejora del flujo de trabajo en momentos de alta afluencia.
- Apoyo al cumplimiento de obligaciones legales.

---

## 📌 Estado del proyecto

🚧 Proyecto en desarrollo  
Este repositorio contiene la planificación, diseño y/o implementación del sistema **Campify** como gestor de campings.
