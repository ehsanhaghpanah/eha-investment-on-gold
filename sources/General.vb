'
' calculates the base price for "Gold Bar"
Function CalcBasePrice(ByVal weight As Double) As Double
     
     Dim RawGoldUnitPrice As Double
     Dim MakingFeeRate As Double
     Dim MarginFeeRate As Double
     Dim VATRate As Double

     RawGoldUnitPrice = ThisWorkbook.Worksheets("GoldBar").Range("C3").Value
     MakingFeeRate = ThisWorkbook.Worksheets("GoldBar").Range("C7").Value
     MarginFeeRate = ThisWorkbook.Worksheets("GoldBar").Range("C10").Value
     VATRate = ThisWorkbook.Worksheets("GoldBar").Range("C13").Value

     Dim RawGoldPrice As Double
     Dim MakingFee As Double
     Dim MarginFee As Double
     Dim VAT As Double

     RawGoldPrice = RawGoldUnitPrice * weight
     MakingFee = RawGoldPrice * MakingFeeRate
     MarginFee = RawGoldPrice * MarginFeeRate
     VAT = (MakingFee + MarginFee) * VATRate

     CalcBasePrice = RawGoldPrice + MakingFee + MarginFee + VAT

End Function

'
' returns the constant rate of converting Ounce to Gram(s)
Function OunceToGram() As Double

     OunceToGram = 31.1034768

End Function

'
' converts Ounce(s) to Gram(s)
Function GetGramsByOunce(ByVal ounce As Double) As Double

     GetGramsByOunce = OunceToGram() * ounce

End Function