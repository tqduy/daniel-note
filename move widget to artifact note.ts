src/app/services/operants.service.ts:3:24 - error TS2307: Cannot find module '../../app/core/interfaces/logger'.

3 import { Logger } from '../../app/core/interfaces/logger';


==> add logger to InspektSchemaFormWidget project
------------------------------------------------------------------------------------------------------------------------                             

                         
src/app/services/operants.service.ts:4:35 - error TS2307: Cannot find module '../core/services/inspection/inspection.service'.

4 import { InspectionService } from '../core/services/inspection/inspection.service';

==> go to getPresetDataFromFieldsApi ==> remove InspectionFieldsService, merge them into operantservice (b/c onlye use one place)
==> find a way to exclude inspectionService and get currentinspection() only.
------------------------------------------------------------------------------------------------------------------------                             

                                    ~~~~~~~
src/app/services/operants.service.ts:5:41 - error TS2307: Cannot find module '../core/services/inspection-fields/inspection-fields.service'.

5 import { InspectionFieldsService } from '../core/services/inspection-fields/inspection-fields.service';

------------------------------------------------------------------------------------------------------------------------                             

                                          
src/app/services/operants.service.ts:6:23 - error TS2307: Cannot find module '../models/field.model'.

6 import { Field } from '../models/field.model';

------------------------------------------------------------------------------------------------------------------------                             

                        
src/app/widgets/ionic-calculated-widget/ionic-calculated-widget.ts:5:30 - error TS2307: Cannot find module '../../core/utilities/app-constants'.

5 import { AppConstants } from '../../core/utilities/app-constants';

==> we can use any instead ==> cause some problem with validation and parsing (null and undefined)

------------------------------------------------------------------------------------------------------------------------                             

                               
src/app/widgets/ionic-camera-widget/ionic-camera-widget.ts:4:24 - error TS2307: Cannot find module '../../core/interfaces/logger'.

4 import { Logger } from '../../core/interfaces/logger';

==> logger is an abstract class ==> should move to InspektSchemaFormWidget ? otherwise, no sultion yet!

------------------------------------------------------------------------------------------------------------------------                             

                         
src/app/widgets/ionic-camera-widget/ionic-camera-widget.ts:6:40 - error TS2307: Cannot find module 'src/app/core/services/inspection-photo/inspection-photo.service'.

6 import { InspectionPhotoService } from 'src/app/core/services/inspection-photo/inspection-photo.service';
 ==> inspectionPhotoService only use in widgets module ==> should we move to InspektSchemaFormWidget?
------------------------------------------------------------------------------------------------------------------------                             

                                         
src/app/widgets/ionic-camera-widget/ionic-camera-widget.ts:7:35 - error TS2307: Cannot find module 'src/app/core/services/inspection/inspection.service'.

7 import { InspectionService } from 'src/app/core/services/inspection/inspection.service';

------------------------------------------------------------------------------------------------------------------------                             

                                    
src/app/widgets/ionic-camera-widget/ionic-camera-widget.ts:99:49 - error TS2345: Argument of type 'unknown' is not assignable to parameter of type 'string'.

99                             this.imageUrls.push(uri);

------------------------------------------------------------------------------------------------------------------------                             

                                                   ~~~
src/app/widgets/ionic-diagram-widget/diagram/diagram.ts:7:33 - error TS2307: Cannot find module '../../../models/coordinates.model'.

7 import { CoordinateModel } from '../../../models/coordinates.model';
==> only use in widgets module ==> move or use any?
------------------------------------------------------------------------------------------------------------------------                             

                                  
src/app/widgets/ionic-event-button/ionic-event-button.component.ts:2:30 - error TS2307: Cannot find module '../../core/services/event/event.service'.

2 import { EventService } from '../../core/services/event/event.service';

------------------------------------------------------------------------------------------------------------------------                             

                               
src/app/widgets/ionic-event-button/ionic-event-button.component.ts:3:24 - error TS2307: Cannot find module '../../core/interfaces/logger'.

3 import { Logger } from '../../core/interfaces/logger';

------------------------------------------------------------------------------------------------------------------------                             

src/app/widgets/ionic-event-button/ionic-event-button.component.ts:7:29 - error TS2307: Cannot find module 'src/app/core/services/json/json.service'.

7 import { JsonService } from 'src/app/core/services/json/json.service';
==> json.service is a secial case: both use in widget module and inpsket module () ==> but not a business logic ==> can be moved to InspektSchemaFormWidget and use as a library service
------------------------------------------------------------------------------------------------------------------------                             

                              
src/app/widgets/ionic-fields-widget/ionic-fields-widget.ts:4:23 - error TS2307: Cannot find module '../../../app/models/field.model'.

4 import { Field } from '../../../app/models/field.model';

------------------------------------------------------------------------------------------------------------------------                             

                        
src/app/widgets/ionic-fields-widget/ionic-fields-widget.ts:5:24 - error TS2307: Cannot find module '../../../app/core/interfaces/logger'.

5 import { Logger } from '../../../app/core/interfaces/logger';
==> ionic fields widget is unused ==> should be removed?

------------------------------------------------------------------------------------------------------------------------                             

                         
src/app/widgets/ionic-file-widget/ionic-file-widget.ts:5:24 - error TS2307: Cannot find module '../../../app/core/interfaces/logger'.

5 import { Logger } from '../../../app/core/interfaces/logger';
==> ionic file widget is unused ==> should be removed?

------------------------------------------------------------------------------------------------------------------------                             

                                         
src/app/widgets/ionic-select-with-search-widget/ionic-select-with-search-widget.ts:6:29 - error TS2307: Cannot find module 'src/app/core/services/http/http.service'.

6 import { HttpService } from 'src/app/core/services/http/http.service';

------------------------------------------------------------------------------------------------------------------------                             

                              
src/app/widgets/ionic-select-with-search-widget/ionic-select-with-search-widget.ts:123:69 - error TS2339: Property 'apiEndpoint' does not exist on type '{ production: boolean; }'.

123             const result = (await this.httpService.post(environment.apiEndpoint + 'proxies', payload).toPromise()).data;

------------------------------------------------------------------------------------------------------------------------                             


src/app/widgets/ionic-submit-widget/ionic-submit-widget.ts:4:30 - error TS2307: Cannot find module '../../core/utilities/app-constants'.

4 import { AppConstants } from '../../core/utilities/app-constants';

------------------------------------------------------------------------------------------------------------------------                             

                               
src/app/widgets/ionic-submit-widget/ionic-submit-widget.ts:6:29 - error TS2307: Cannot find module 'src/app/core/services/json/json.service'.

6 import { JsonService } from 'src/app/core/services/json/json.service';

------------------------------------------------------------------------------------------------------------------------                             

                              
src/app/widgets/ionic-text-widget/ionic-text-widget.ts:4:24 - error TS2307: Cannot find module '../../core/interfaces/logger'.

4 import { Logger } from '../../core/interfaces/logger';