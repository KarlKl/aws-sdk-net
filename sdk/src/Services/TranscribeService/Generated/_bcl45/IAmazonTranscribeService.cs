/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TranscribeService.Model;

namespace Amazon.TranscribeService
{
    /// <summary>
    /// Interface for accessing TranscribeService
    ///
    /// Operations and objects for transcribing speech to text.
    /// </summary>
    public partial interface IAmazonTranscribeService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITranscribeServicePaginatorFactory Paginators { get; }

        
        #region  CreateCallAnalyticsCategory


        /// <summary>
        /// Creates a call analytics category. Amazon Transcribe applies the conditions specified
        /// by your call analytics categories to your call analytics jobs. For each analytics
        /// category, you must create between 1 and 20 rules. For example, you can create a 'greeting'
        /// category with a rule that flags calls in which your agent does not use a specified
        /// phrase (for example: "Please note this call may be recorded.") in the first 15 seconds
        /// of the call. When you start a call analytics job, Amazon Transcribe applies all your
        /// existing call analytics categories to that job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        CreateCallAnalyticsCategoryResponse CreateCallAnalyticsCategory(CreateCallAnalyticsCategoryRequest request);



        /// <summary>
        /// Creates a call analytics category. Amazon Transcribe applies the conditions specified
        /// by your call analytics categories to your call analytics jobs. For each analytics
        /// category, you must create between 1 and 20 rules. For example, you can create a 'greeting'
        /// category with a rule that flags calls in which your agent does not use a specified
        /// phrase (for example: "Please note this call may be recorded.") in the first 15 seconds
        /// of the call. When you start a call analytics job, Amazon Transcribe applies all your
        /// existing call analytics categories to that job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        Task<CreateCallAnalyticsCategoryResponse> CreateCallAnalyticsCategoryAsync(CreateCallAnalyticsCategoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLanguageModel


        /// <summary>
        /// Creates a new custom language model. When creating a new language model, you must
        /// specify if you want a Wideband (audio sample rates over 16,000 Hz) or Narrowband (audio
        /// sample rates under 16,000 Hz) base model. You then include the S3 URI location of
        /// your training and tuning files, the language for the model, a unique name, and any
        /// tags you want associated with your model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        CreateLanguageModelResponse CreateLanguageModel(CreateLanguageModelRequest request);



        /// <summary>
        /// Creates a new custom language model. When creating a new language model, you must
        /// specify if you want a Wideband (audio sample rates over 16,000 Hz) or Narrowband (audio
        /// sample rates under 16,000 Hz) base model. You then include the S3 URI location of
        /// your training and tuning files, the language for the model, a unique name, and any
        /// tags you want associated with your model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        Task<CreateLanguageModelResponse> CreateLanguageModelAsync(CreateLanguageModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMedicalVocabulary


        /// <summary>
        /// Creates a new custom medical vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new medical vocabulary, you must upload a text file that contains
        /// your new entries, phrases, and terms into an S3 bucket. Note that this differs from
        /// , where you can include a list of terms within your request using the <code>Phrases</code>
        /// flag, as <code>CreateMedicalVocabulary</code> does not support the <code>Phrases</code>
        /// flag.
        /// </para>
        ///  
        /// <para>
        /// For more information on creating a custom vocabulary text file, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary-create.html">Creating
        /// a custom vocabulary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        CreateMedicalVocabularyResponse CreateMedicalVocabulary(CreateMedicalVocabularyRequest request);



        /// <summary>
        /// Creates a new custom medical vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new medical vocabulary, you must upload a text file that contains
        /// your new entries, phrases, and terms into an S3 bucket. Note that this differs from
        /// , where you can include a list of terms within your request using the <code>Phrases</code>
        /// flag, as <code>CreateMedicalVocabulary</code> does not support the <code>Phrases</code>
        /// flag.
        /// </para>
        ///  
        /// <para>
        /// For more information on creating a custom vocabulary text file, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary-create.html">Creating
        /// a custom vocabulary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        Task<CreateMedicalVocabularyResponse> CreateMedicalVocabularyAsync(CreateMedicalVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVocabulary


        /// <summary>
        /// Creates a new custom vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new medical vocabulary, you can either upload a text file that contains
        /// your new entries, phrases, and terms into an S3 bucket or include a list of terms
        /// directly in your request using the <code>Phrases</code> flag.
        /// </para>
        ///  
        /// <para>
        /// For more information on creating a custom vocabulary, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary-create.html">Creating
        /// a custom vocabulary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest request);



        /// <summary>
        /// Creates a new custom vocabulary.
        /// 
        ///  
        /// <para>
        /// When creating a new medical vocabulary, you can either upload a text file that contains
        /// your new entries, phrases, and terms into an S3 bucket or include a list of terms
        /// directly in your request using the <code>Phrases</code> flag.
        /// </para>
        ///  
        /// <para>
        /// For more information on creating a custom vocabulary, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary-create.html">Creating
        /// a custom vocabulary</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        Task<CreateVocabularyResponse> CreateVocabularyAsync(CreateVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVocabularyFilter


        /// <summary>
        /// Creates a new vocabulary filter that you can use to filter words from your transcription
        /// output. For example, you can use this operation to remove profanity from your transcript.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        CreateVocabularyFilterResponse CreateVocabularyFilter(CreateVocabularyFilterRequest request);



        /// <summary>
        /// Creates a new vocabulary filter that you can use to filter words from your transcription
        /// output. For example, you can use this operation to remove profanity from your transcript.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        Task<CreateVocabularyFilterResponse> CreateVocabularyFilterAsync(CreateVocabularyFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCallAnalyticsCategory


        /// <summary>
        /// Deletes a call analytics category. To use this operation, specify the name of the
        /// category you want to delete using <code>CategoryName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        DeleteCallAnalyticsCategoryResponse DeleteCallAnalyticsCategory(DeleteCallAnalyticsCategoryRequest request);



        /// <summary>
        /// Deletes a call analytics category. To use this operation, specify the name of the
        /// category you want to delete using <code>CategoryName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        Task<DeleteCallAnalyticsCategoryResponse> DeleteCallAnalyticsCategoryAsync(DeleteCallAnalyticsCategoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCallAnalyticsJob


        /// <summary>
        /// Deletes a call analytics job. To use this operation, specify the name of the job you
        /// want to delete using <code>CallAnalyticsJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        DeleteCallAnalyticsJobResponse DeleteCallAnalyticsJob(DeleteCallAnalyticsJobRequest request);



        /// <summary>
        /// Deletes a call analytics job. To use this operation, specify the name of the job you
        /// want to delete using <code>CallAnalyticsJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        Task<DeleteCallAnalyticsJobResponse> DeleteCallAnalyticsJobAsync(DeleteCallAnalyticsJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLanguageModel


        /// <summary>
        /// Deletes a custom language model. To use this operation, specify the name of the language
        /// model you want to delete using <code>ModelName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        DeleteLanguageModelResponse DeleteLanguageModel(DeleteLanguageModelRequest request);



        /// <summary>
        /// Deletes a custom language model. To use this operation, specify the name of the language
        /// model you want to delete using <code>ModelName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        Task<DeleteLanguageModelResponse> DeleteLanguageModelAsync(DeleteLanguageModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMedicalTranscriptionJob


        /// <summary>
        /// Deletes a medical transcription job, along with any related information. To use this
        /// operation, specify the name of the job you want to delete using <code>MedicalTranscriptionJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        DeleteMedicalTranscriptionJobResponse DeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request);



        /// <summary>
        /// Deletes a medical transcription job, along with any related information. To use this
        /// operation, specify the name of the job you want to delete using <code>MedicalTranscriptionJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        Task<DeleteMedicalTranscriptionJobResponse> DeleteMedicalTranscriptionJobAsync(DeleteMedicalTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMedicalVocabulary


        /// <summary>
        /// Deletes a custom medical vocabulary. To use this operation, specify the name of the
        /// vocabulary you want to delete using <code>VocabularyName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        DeleteMedicalVocabularyResponse DeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request);



        /// <summary>
        /// Deletes a custom medical vocabulary. To use this operation, specify the name of the
        /// vocabulary you want to delete using <code>VocabularyName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        Task<DeleteMedicalVocabularyResponse> DeleteMedicalVocabularyAsync(DeleteMedicalVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTranscriptionJob


        /// <summary>
        /// Deletes a transcription job, along with any related information. To use this operation,
        /// specify the name of the job you want to delete using <code>TranscriptionJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        DeleteTranscriptionJobResponse DeleteTranscriptionJob(DeleteTranscriptionJobRequest request);



        /// <summary>
        /// Deletes a transcription job, along with any related information. To use this operation,
        /// specify the name of the job you want to delete using <code>TranscriptionJobName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        Task<DeleteTranscriptionJobResponse> DeleteTranscriptionJobAsync(DeleteTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVocabulary


        /// <summary>
        /// Deletes a custom vocabulary. To use this operation, specify the name of the vocabulary
        /// you want to delete using <code>VocabularyName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest request);



        /// <summary>
        /// Deletes a custom vocabulary. To use this operation, specify the name of the vocabulary
        /// you want to delete using <code>VocabularyName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        Task<DeleteVocabularyResponse> DeleteVocabularyAsync(DeleteVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVocabularyFilter


        /// <summary>
        /// Deletes a vocabulary filter. To use this operation, specify the name of the vocabulary
        /// filter you want to delete using <code>VocabularyFilterName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        DeleteVocabularyFilterResponse DeleteVocabularyFilter(DeleteVocabularyFilterRequest request);



        /// <summary>
        /// Deletes a vocabulary filter. To use this operation, specify the name of the vocabulary
        /// filter you want to delete using <code>VocabularyFilterName</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        Task<DeleteVocabularyFilterResponse> DeleteVocabularyFilterAsync(DeleteVocabularyFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLanguageModel


        /// <summary>
        /// Provides information about a specific custom language model in your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation also shows if the base language model you used to create your custom
        /// language model has been updated. If Amazon Transcribe has updated the base model,
        /// you can create a new custom language model using the updated base model.
        /// </para>
        ///  
        /// <para>
        /// If you tried to create a new custom language model and the request wasn't successful,
        /// you can use this operation to help identify the reason. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        DescribeLanguageModelResponse DescribeLanguageModel(DescribeLanguageModelRequest request);



        /// <summary>
        /// Provides information about a specific custom language model in your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation also shows if the base language model you used to create your custom
        /// language model has been updated. If Amazon Transcribe has updated the base model,
        /// you can create a new custom language model using the updated base model.
        /// </para>
        ///  
        /// <para>
        /// If you tried to create a new custom language model and the request wasn't successful,
        /// you can use this operation to help identify the reason. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        Task<DescribeLanguageModelResponse> DescribeLanguageModelAsync(DescribeLanguageModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCallAnalyticsCategory


        /// <summary>
        /// Retrieves information about a call analytics category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        GetCallAnalyticsCategoryResponse GetCallAnalyticsCategory(GetCallAnalyticsCategoryRequest request);



        /// <summary>
        /// Retrieves information about a call analytics category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        Task<GetCallAnalyticsCategoryResponse> GetCallAnalyticsCategoryAsync(GetCallAnalyticsCategoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCallAnalyticsJob


        /// <summary>
        /// Retrieves information about a call analytics job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to the <code>CallAnalyticsJobStatus</code> field.
        /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
        /// transcript at the URI specified in the <code>TranscriptFileUri</code> field. If you
        /// enabled personally identifiable information (PII) redaction, the redacted transcript
        /// appears in the <code>RedactedTranscriptFileUri</code> field.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        GetCallAnalyticsJobResponse GetCallAnalyticsJob(GetCallAnalyticsJobRequest request);



        /// <summary>
        /// Retrieves information about a call analytics job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to the <code>CallAnalyticsJobStatus</code> field.
        /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
        /// transcript at the URI specified in the <code>TranscriptFileUri</code> field. If you
        /// enabled personally identifiable information (PII) redaction, the redacted transcript
        /// appears in the <code>RedactedTranscriptFileUri</code> field.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        Task<GetCallAnalyticsJobResponse> GetCallAnalyticsJobAsync(GetCallAnalyticsJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMedicalTranscriptionJob


        /// <summary>
        /// Retrieves information about a medical transcription job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to the <code>TranscriptionJobStatus</code> field.
        /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
        /// transcript at the URI specified in the <code>TranscriptFileUri</code> field.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        GetMedicalTranscriptionJobResponse GetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request);



        /// <summary>
        /// Retrieves information about a medical transcription job.
        /// 
        ///  
        /// <para>
        /// To view the job's status, refer to the <code>TranscriptionJobStatus</code> field.
        /// If the status is <code>COMPLETED</code>, the job is finished. You can then find your
        /// transcript at the URI specified in the <code>TranscriptFileUri</code> field.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        Task<GetMedicalTranscriptionJobResponse> GetMedicalTranscriptionJobAsync(GetMedicalTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMedicalVocabulary


        /// <summary>
        /// Retrieves information about a medical vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        GetMedicalVocabularyResponse GetMedicalVocabulary(GetMedicalVocabularyRequest request);



        /// <summary>
        /// Retrieves information about a medical vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        Task<GetMedicalVocabularyResponse> GetMedicalVocabularyAsync(GetMedicalVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTranscriptionJob


        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>TranscriptionJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable content redaction, the redacted
        /// transcript appears in <code>RedactedTranscriptFileUri</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request);



        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>TranscriptionJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable content redaction, the redacted
        /// transcript appears in <code>RedactedTranscriptFileUri</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        Task<GetTranscriptionJobResponse> GetTranscriptionJobAsync(GetTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVocabulary


        /// <summary>
        /// Gets information about a vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        GetVocabularyResponse GetVocabulary(GetVocabularyRequest request);



        /// <summary>
        /// Gets information about a vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        Task<GetVocabularyResponse> GetVocabularyAsync(GetVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVocabularyFilter


        /// <summary>
        /// Returns information about a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        GetVocabularyFilterResponse GetVocabularyFilter(GetVocabularyFilterRequest request);



        /// <summary>
        /// Returns information about a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        Task<GetVocabularyFilterResponse> GetVocabularyFilterAsync(GetVocabularyFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCallAnalyticsCategories


        /// <summary>
        /// Provides more information about the call analytics categories that you've created.
        /// You can use the information in this list to find a specific category. You can then
        /// use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories service method.</param>
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        ListCallAnalyticsCategoriesResponse ListCallAnalyticsCategories(ListCallAnalyticsCategoriesRequest request);



        /// <summary>
        /// Provides more information about the call analytics categories that you've created.
        /// You can use the information in this list to find a specific category. You can then
        /// use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        Task<ListCallAnalyticsCategoriesResponse> ListCallAnalyticsCategoriesAsync(ListCallAnalyticsCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCallAnalyticsJobs


        /// <summary>
        /// List call analytics jobs with a specified status or substring that matches their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs service method.</param>
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        ListCallAnalyticsJobsResponse ListCallAnalyticsJobs(ListCallAnalyticsJobsRequest request);



        /// <summary>
        /// List call analytics jobs with a specified status or substring that matches their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        Task<ListCallAnalyticsJobsResponse> ListCallAnalyticsJobsAsync(ListCallAnalyticsJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLanguageModels


        /// <summary>
        /// Provides more information about the custom language models you've created. You can
        /// use the information in this list to find a specific custom language model. You can
        /// then use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        ListLanguageModelsResponse ListLanguageModels(ListLanguageModelsRequest request);



        /// <summary>
        /// Provides more information about the custom language models you've created. You can
        /// use the information in this list to find a specific custom language model. You can
        /// then use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        Task<ListLanguageModelsResponse> ListLanguageModelsAsync(ListLanguageModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMedicalTranscriptionJobs


        /// <summary>
        /// Lists medical transcription jobs with a specified status or substring that matches
        /// their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        ListMedicalTranscriptionJobsResponse ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request);



        /// <summary>
        /// Lists medical transcription jobs with a specified status or substring that matches
        /// their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        Task<ListMedicalTranscriptionJobsResponse> ListMedicalTranscriptionJobsAsync(ListMedicalTranscriptionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMedicalVocabularies


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If you don't enter
        /// a value in any of the request parameters, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        ListMedicalVocabulariesResponse ListMedicalVocabularies(ListMedicalVocabulariesRequest request);



        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If you don't enter
        /// a value in any of the request parameters, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        Task<ListMedicalVocabulariesResponse> ListMedicalVocabulariesAsync(ListMedicalVocabulariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a given transcription job, vocabulary, or resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags associated with a given transcription job, vocabulary, or resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTranscriptionJobs


        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request);



        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        Task<ListTranscriptionJobsResponse> ListTranscriptionJobsAsync(ListTranscriptionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVocabularies


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If no criteria are
        /// specified, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        ListVocabulariesResponse ListVocabularies(ListVocabulariesRequest request);



        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If no criteria are
        /// specified, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        Task<ListVocabulariesResponse> ListVocabulariesAsync(ListVocabulariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVocabularyFilters


        /// <summary>
        /// Gets information about vocabulary filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        ListVocabularyFiltersResponse ListVocabularyFilters(ListVocabularyFiltersRequest request);



        /// <summary>
        /// Gets information about vocabulary filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        Task<ListVocabularyFiltersResponse> ListVocabularyFiltersAsync(ListVocabularyFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCallAnalyticsJob


        /// <summary>
        /// Starts an asynchronous analytics job that not only transcribes the audio recording
        /// of a caller and agent, but also returns additional insights. These insights include
        /// how quickly or loudly the caller or agent was speaking. To retrieve additional insights
        /// with your analytics jobs, create categories. A category is a way to classify analytics
        /// jobs based on attributes, such as a customer's sentiment or a particular phrase being
        /// used during the call. For more information, see the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        StartCallAnalyticsJobResponse StartCallAnalyticsJob(StartCallAnalyticsJobRequest request);



        /// <summary>
        /// Starts an asynchronous analytics job that not only transcribes the audio recording
        /// of a caller and agent, but also returns additional insights. These insights include
        /// how quickly or loudly the caller or agent was speaking. To retrieve additional insights
        /// with your analytics jobs, create categories. A category is a way to classify analytics
        /// jobs based on attributes, such as a customer's sentiment or a particular phrase being
        /// used during the call. For more information, see the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        Task<StartCallAnalyticsJobResponse> StartCallAnalyticsJobAsync(StartCallAnalyticsJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMedicalTranscriptionJob


        /// <summary>
        /// Starts a batch job to transcribe medical speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        StartMedicalTranscriptionJobResponse StartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request);



        /// <summary>
        /// Starts a batch job to transcribe medical speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        Task<StartMedicalTranscriptionJobResponse> StartMedicalTranscriptionJobAsync(StartMedicalTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTranscriptionJob


        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request);



        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        Task<StartTranscriptionJobResponse> StartTranscriptionJobAsync(StartTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags an Amazon Transcribe resource with the given list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tags an Amazon Transcribe resource with the given list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes specified tags from a specified Amazon Transcribe resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes specified tags from a specified Amazon Transcribe resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCallAnalyticsCategory


        /// <summary>
        /// Updates the call analytics category with new values. The <code>UpdateCallAnalyticsCategory</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        UpdateCallAnalyticsCategoryResponse UpdateCallAnalyticsCategory(UpdateCallAnalyticsCategoryRequest request);



        /// <summary>
        /// Updates the call analytics category with new values. The <code>UpdateCallAnalyticsCategory</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        Task<UpdateCallAnalyticsCategoryResponse> UpdateCallAnalyticsCategoryAsync(UpdateCallAnalyticsCategoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMedicalVocabulary


        /// <summary>
        /// Updates a vocabulary with new values that you provide in a different text file from
        /// the one you used to create the vocabulary. The <code>UpdateMedicalVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        UpdateMedicalVocabularyResponse UpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request);



        /// <summary>
        /// Updates a vocabulary with new values that you provide in a different text file from
        /// the one you used to create the vocabulary. The <code>UpdateMedicalVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        Task<UpdateMedicalVocabularyResponse> UpdateMedicalVocabularyAsync(UpdateMedicalVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateVocabulary


        /// <summary>
        /// Updates an existing vocabulary with new values. The <code>UpdateVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        UpdateVocabularyResponse UpdateVocabulary(UpdateVocabularyRequest request);



        /// <summary>
        /// Updates an existing vocabulary with new values. The <code>UpdateVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        Task<UpdateVocabularyResponse> UpdateVocabularyAsync(UpdateVocabularyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateVocabularyFilter


        /// <summary>
        /// Updates a vocabulary filter with a new list of filtered words.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        UpdateVocabularyFilterResponse UpdateVocabularyFilter(UpdateVocabularyFilterRequest request);



        /// <summary>
        /// Updates a vocabulary filter with a new list of filtered words.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        Task<UpdateVocabularyFilterResponse> UpdateVocabularyFilterAsync(UpdateVocabularyFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}