# Parámetros de la distribución
media <- 30
desviacion_estandar <- 5

# Generar muestra de 200 valores con distribución normal
set.seed(123) # Para reproducibilidad
muestra <- rnorm(200, mean = media, sd = desviacion_estandar)

# Realizar la prueba de normalidad de Shapiro-Wilk
resultado_prueba <- shapiro.test(muestra)

# Mostrar el resultado
print(resultado_prueba)
