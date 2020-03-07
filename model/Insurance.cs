namespace Classes
{
	public class Insurance
	{
		private double monthlyPayment = 0.0;
		private double franchiseValue = 0.0;
		private double theftCoverageValue = 0.0;
		private double disastersCoverageValue = 0.0;

		private bool isTheftCoverage;
		private bool isDisastersCoverage;

		public Insurance(bool isTheftCoverage, bool isDisastersCoverage, Property property)
		{
			this.isTheftCoverage = isTheftCoverage;
			this.isDisastersCoverage = isDisastersCoverage;
			
			setMonthlyPayment(property.getValue(), property.getCity().getIndividualIndex());			
			setDisastersCoverageValue();
			setTheftCoverageValue(property.getHasAlarme(), property.getGoodsValue());

			monthlyPayment = monthlyPayment + disastersCoverageValue + theftCoverageValue;

			setFranchiseValue();
		}

		private void setMonthlyPayment(double propertyValue, double individualIndex)
		{
			monthlyPayment = propertyValue / 12 * individualIndex;
		}

		public double getMonthlyPayment()
		{
			return monthlyPayment;
		}

		private void setFranchiseValue()
		{
			franchiseValue = monthlyPayment * 10;
		}

		public double getFranchiseValue()
		{
			return franchiseValue;
		}

		private void setTheftCoverageValue(bool hasAlarm, double goodsValue)
		{
			if (isTheftCoverage)
			{
				theftCoverageValue = goodsValue * (hasAlarm ? 0.01 : 0.02);
			}
		}

		private void setDisastersCoverageValue()
		{
			if (isDisastersCoverage)
			{
				disastersCoverageValue = monthlyPayment * 0.05;
			}
		}

	}

}

