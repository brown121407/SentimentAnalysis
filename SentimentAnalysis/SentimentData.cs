﻿using Microsoft.ML.Runtime.Api;

namespace SentimentAnalysis
{
	public class SentimentData
	{
		[Column(ordinal: "0", name: "Label")]
		public float Sentiment;
		[Column(ordinal: "1")]
		public string SentimentText;
	}

	public class SentimentPrediction
	{
		[ColumnName("PredictedLabel")]
		public bool Prediction { get; set; }

		[ColumnName("Probability")]
		public float Probability { get; set; }

		[ColumnName("Score")]
		public float Score { get; set; }
	}
}
