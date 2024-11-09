# Parámetros de las distribuciones
media_x <- 10
desviacion_x <- 3
media_y <- 15
desviacion_y <- 4

# Generar muestras de 100 observaciones cada una
set.seed(123)  # Para reproducibilidad
muestra_x <- rnorm(100, mean = media_x, sd = desviacion_x)
muestra_y <- rnorm(100, mean = media_y, sd = desviacion_y)

# Sumar las muestras X y Y para crear la nueva muestra Z
muestra_z <- muestra_x + muestra_y

# Calcular la media y desviación estándar de la muestra Z
media_z_obtenida <- mean(muestra_z)
desviacion_z_obtenida <- sd(muestra_z)

# Calcular los valores teóricos esperados
media_z_esperada <- media_x + media_y
desviacion_z_esperada <- sqrt(desviacion_x^2 + desviacion_y^2)

# Mostrar los resultados
cat("Muestra Z - Media obtenida:", media_z_obtenida, ", Desviación estándar obtenida:", desviacion_z_obtenida, "\n")
cat("Muestra Z - Media esperada:", media_z_esperada, ", Desviación estándar esperada:", desviacion_z_esperada, "\n")

# Graficar la distribución de la muestra Z
hist(muestra_z, breaks = 30, col = rgb(0.3, 0.6, 0.9, 0.6), 
     main = "Distribución de la Muestra Z (X + Y)", 
     xlab = "Valores", ylab = "Frecuencia", border = "black")

# Añadir líneas de la media y desviación estándar esperadas
abline(v = media_z_esperada, col = "red", lwd = 2, lty = 2)
abline(v = media_z_obtenida, col = "green", lwd = 2, lty = 2)

# Añadir leyenda
legend("topright", legend = c("Media Teórica", "Media Obtenida"), 
       col = c("red", "green"), lwd = 2, lty = 2)
