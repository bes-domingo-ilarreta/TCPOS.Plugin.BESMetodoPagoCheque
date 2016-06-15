CREATE TABLE bes_banks (
id                  INTEGER         
						IDENTITY(1,1)
                        CONSTRAINT pk_bes_banks_id
                        PRIMARY KEY
                        CONSTRAINT ck_bes_banks_id
                        CHECK (id > 0),
description			VARCHAR(40)		NOT NULL,
status				NUMERIC(1)      
						CONSTRAINT bit_bes_banks_status
                        CHECK (status IN (0,1))
)
GO

CREATE TABLE trans_bes_cheque (
transaction_id		INTEGER         NOT NULL
						CONSTRAINT fk_trans_bes_cheque_transactions
                        REFERENCES transactions(id)
                        ON DELETE CASCADE,
shop_id				INTEGER			NOT NULL
						CONSTRAINT fk_trans_bes_cheque_shops
						REFERENCES shops(id),
till_id				INTEGER			NOT NULL
						CONSTRAINT fk_trans_bes_cheque_tills
						REFERENCES tills(id),
trans_num			NUMERIC(9)      NOT NULL,
bank_id				INTEGER			NOT NULL
						CONSTRAINT fk_trans_bes_cheque_bes_banks
						REFERENCES bes_banks(id),
rut_cheque			VARCHAR(10)		NOT NULL,
nro_cta_corriente	VARCHAR(15)		NOT NULL,
nro_cheque			VARCHAR(15)		NOT NULL,
monto				NUMERIC(15,3)	NOT NULL,
code_auth			VARCHAR(20)		NOT NULL,
nombre_completo		VARCHAR(50)		NOT NULL,
tasas				NUMERIC(4),
fecha				DATETIME		NOT NULL
)
GO