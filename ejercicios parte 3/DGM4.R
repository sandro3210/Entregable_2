# Parámetros de las distribuciones
media_a <- 55
desviacion_a <- 10
media_b <- 65
desviacion_b <- 15

# Generar muestras
set.seed(123) # Para reproducibilidad
muestra_a <- rnorm(1000, mean = media_a, sd = desviacion_a)
muestra_b <- rnorm(1000, mean = media_b, sd = desviacion_b)

# Calcular la media y desviación estándar de cada muestra
media_a_obtenida <- mean(muestra_a)
desviacion_a_obtenida <- sd(muestra_a)
media_b_obtenida <- mean(muestra_b)
desviacion_b_obtenida <- sd(muestra_b)

# Mostrar resultados
cat("Muestra A - Media:", media_a_obtenida, ", Desviación estándar:", desviacion_a_obtenida, "\n")
cat("Muestra B - Media:", media_b_obtenida, ", Desviación estándar:", desviacion_b_obtenida, "\n")

# Graficar ambas distribuciones en el mismo histograma
hist(muestra_a, breaks = 30, col = rgb(1, 0.5, 0, 0.5), xlim = c(20, 100), 
     main = "Comparación de Muestras A y B", xlab = "Valores", ylab = "Frecuencia", 
     border = "black")
hist(muestra_b, breaks = 30, col = rgb(0.3, 0.6, 1, 0.5), add = TRUE, border = "black")
legend("topright", legend = c("Muestra A", "Muestra B"), 
       fill = c(rgb(1, 0.5, 0, 0.5), rgb(0.3, 0.6, 1, 0.5)), border = "black")
