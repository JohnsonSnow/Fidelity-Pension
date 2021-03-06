﻿select top 500 E.PIN, E.FIRSTNAME, E.SURNAME, E.MOBILE_PHONE, E.EMAIL, E.EMPLOYER_NAME, E.EMPLOYER_RCNO, (SELECT DESCRIPTION FROM STATES WHERE CODE = E.STATE_OF_POSTING) AS LOCATION,
E.AGENT_CODE,(select agent_name from agent where agent_code = isnull(E.agent_code,'')) as AGENT_NAME,
CASE E.SCHEME_ID
	WHEN 6 THEN 'FUND I'
	WHEN 1 THEN 'FUND II'
	WHEN 7 THEN 'FUND III'
	WHEN 2 THEN 'FUND IV'
END AS FUND,
CASE E.SCHEME_ID
	WHEN 6 THEN SUM(ISNULL(C.TOTAL_CONTRIBUTION, 0.00)) + SUM(ISNULL(C.OTHER_CONTRIBUTION,0.00)) * 1.0227
	WHEN 1 THEN SUM(ISNULL(C.TOTAL_CONTRIBUTION, 0.00)) + SUM(ISNULL(C.OTHER_CONTRIBUTION,0.00)) * 2.8441
	WHEN 7 THEN SUM(ISNULL(C.TOTAL_CONTRIBUTION, 0.00)) + SUM(ISNULL(C.OTHER_CONTRIBUTION,0.00)) * 1.0652
	WHEN 2 THEN SUM(ISNULL(C.TOTAL_CONTRIBUTION, 0.00)) + SUM(ISNULL(C.OTHER_CONTRIBUTION,0.00)) * 2.8593
END AS CURRENT_VALUE,
SUM(ISNULL(C.TOTAL_CONTRIBUTION, 0.00)) + SUM(ISNULL(C.OTHER_CONTRIBUTION,0.00)) AS TOT_CONTRIBUTION
FROM EMPLOYEES E, CONTRIBUTION C
WHERE E.PIN = C.PIN AND E.PIN LIKE 'PEN%' AND E.PIN_INVALID = 0 AND ISNULL(C.WITHDRAWAL,0.00) + ISNULL(C.WITHDRAWAL_VC,0.00)  >= 0
GROUP BY E.PIN, E.FIRSTNAME, E.SURNAME, E.MOBILE_PHONE, E.EMAIL, E.EMPLOYER_NAME, E.EMPLOYER_RCNO,E.STATE_OF_POSTING,E.AGENT_CODE, E.SCHEME_ID
ORDER BY CURRENT_VALUE DESC