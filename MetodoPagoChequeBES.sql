/****** Campos para Cheques BES Consulting  ******/

ALTER TABLE trans_payments
/*
DROP 
	COLUMN rut_cheque,
	COLUMN nombre_cheque
*/
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