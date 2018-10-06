"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var productTable_component_1 = require("./structure/productTable.component");
var productDetail_component_1 = require("./structure/productDetail.component");
var productSelection_component_1 = require("./store/productSelection.component");
var routes = [
    { path: "store", component: productSelection_component_1.ProductSelectionComponent },
    { path: "", component: productSelection_component_1.ProductSelectionComponent },
    { path: "table", component: productTable_component_1.ProductTableComponent },
    { path: "detail/:id", component: productDetail_component_1.ProductDetailComponent },
    { path: "detail", component: productDetail_component_1.ProductDetailComponent }
];
exports.RoutingConfig = router_1.RouterModule.forRoot(routes);
//# sourceMappingURL=app.routing.js.map