/****** Campos para Cheques BES Consulting  ******/

ALTER TABLE trans_payments

DROP 
	COLUMN x_banco_cheque,
	COLUMN x_numero_cheque,
	COLUMN x_tasas_cheque,
	COLUMN x_rut_cheque,
	COLUMN x_codigo_autorizacion_cheque,
	COLUMN x_fecha_cheque,
	COLUMN x_numero_cuenta_corriente,
	COLUMN x_nombre_completo

/*
ADD 
x_banco_cheque					VARCHAR(40),
x_numero_cheque					INTEGER,
/* x_monto_cheque = amount */
x_tasas_cheque					DECIMAL,                                   
x_rut_cheque					VARCHAR(40),
x_codigo_autorizacion_cheque	VARCHAR(100),
x_fecha_cheque					DATETIME,
x_numero_cuenta_corriente		INTEGER,
x_nombre_completo				VARCHAR(40)	
*/