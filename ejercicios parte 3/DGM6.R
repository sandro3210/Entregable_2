# Parámetros de la distribución
media <- 50
desviacion_estandar <- 12

# Calcular la probabilidad de que un valor sea mayor que 70
probabilidad_mayor_70 <- 1 - pnorm(70, mean = media, sd = desviacion_estandar)

# Mostrar el resultado
cat("La probabilidad de que un valor sea mayor que 70 es:", probabilidad_mayor_70, "\n")
