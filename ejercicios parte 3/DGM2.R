# Parámetros de la distribución
media <- 40
desviacion_estandar <- 5

# Calcular probabilidades acumuladas para 35 y 45
prob_45 <- pnorm(45, mean = media, sd = desviacion_estandar)
prob_35 <- pnorm(35, mean = media, sd = desviacion_estandar)

# Probabilidad de que el valor esté entre 35 y 45
probabilidad <- prob_45 - prob_35
print(probabilidad)

# Graficar la distribución normal
curve(dnorm(x, mean = media, sd = desviacion_estandar), from = 20, to = 60, 
      main = "Distribución Normal con Media 40 y Desviación Estándar 5", 
      xlab = "Valores", ylab = "Densidad", col = "blue", lwd = 2)

# Sombrear el área entre 35 y 45
x_sombra <- seq(35, 45, length = 100)
y_sombra <- dnorm(x_sombra, mean = media, sd = desviacion_estandar)
polygon(c(35, x_sombra, 45), c(0, y_sombra, 0), col = "skyblue", border = NA)

# Añadir líneas verticales para 35 y 45
abline(v = 35, col = "red", lty = 2)
abline(v = 45, col = "red", lty = 2)

# Mostrar la probabilidad calculada en el gráfico
text(40, 0.05, paste("P(35 < X < 45) =", round(probabilidad, 4)), col = "black", cex = 1.2)
print(probabilidad)
